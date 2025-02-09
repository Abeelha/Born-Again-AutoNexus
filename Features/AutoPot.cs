using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using MelonLoader;
using Il2Cpp;
using AutoNexus.Configuration;
using AutoNexus.Constants;
using AutoNexus.Helpers;
using AutoNexus.Utils;
using System.Runtime.CompilerServices;

namespace AutoNexus.Features
{
    public class AutoPot
    {
        private readonly MelonLogger.Instance _logger;
        private readonly ModConfig _config;
        private readonly SoundManager _soundManager;
        private GameObject _playerCharacter;
        private Character _characterComponent;
        private readonly HealthMonitorState _monitorState = HealthMonitoringHelper.SharedState;
        private bool _isSimulatingKeyPress;
        private byte _autoPotKey;
        private bool _gracePeriodActive;
        private bool _autoPotEnabled = true;
        private KeyCode _currentAutoPotToggleKey;

        private const float MIN_UPDATE_INTERVAL = 1f / 165f;
        private const float AUTO_POT_DELAY = 0.5f;
        private const float HEALTH_CHECK_INTERVAL = 0.1f;
        private float _lastHealthCheckTime;

        public AutoPot(MelonLogger.Instance logger, ModConfig config, SoundManager soundManager)
        {
            _logger = logger;
            _config = config;
            _soundManager = soundManager;
            _lastHealthCheckTime = Time.realtimeSinceStartup;
            ParseAutoPotKey();
            UpdateAutoPotToggleKey();
            StartInitialization();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ParseAutoPotKey()
        {
            string keyString = _config.AutoPotKey.Value.Trim();
            if (keyString.Length == 1)
            {
                char ch = keyString[0];
                if (char.IsDigit(ch))
                    keyString = "Alpha" + ch;
                else if (char.IsLetter(ch))
                    keyString = char.ToUpper(ch).ToString();
            }
            try
            {
                KeyCode keyCode = (KeyCode)System.Enum.Parse(typeof(KeyCode), keyString, true);
                _autoPotKey = (byte)keyCode;
            }
            catch (System.Exception ex)
            {
                _logger.Error($"Invalid AutoPotKey '{_config.AutoPotKey.Value}'. Reverting to default '1'. Exception: {ex.Message}");
                _autoPotKey = (byte)KeyCode.Alpha1;
                _config.AutoPotKey.Value = "1";
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void UpdateAutoPotToggleKey()
        {
            string keyString = _config.AutoPotToggleKey.Value.ToUpper();
            if (keyString == "ENTER") keyString = "RETURN";

            try
            {
                _currentAutoPotToggleKey = (KeyCode)System.Enum.Parse(typeof(KeyCode), keyString, true);
            }
            catch (System.ArgumentException)
            {
                _logger.Error($"Invalid AutoPotToggleKey '{_config.AutoPotToggleKey.Value}' in config. Reverting to default 'H'.");
                _currentAutoPotToggleKey = KeyCode.H;
                _config.AutoPotToggleKey.Value = "H";
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void StartInitialization()
        {
            MelonCoroutines.Start(InitializePlayer());
        }

        private IEnumerator InitializePlayer()
        {
            var waitInterval = new WaitForSeconds(ModDefaults.INIT_CHECK_INTERVAL);

            while (true)
            {
                if (TryInitializePlayer())
                {
                    _logger.Msg("AutoPot: Player initialized successfully.");
                    yield break;
                }
                yield return waitInterval;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool TryInitializePlayer()
        {
            _playerCharacter = GameObject.Find(ModDefaults.PLAYER_OBJECT_NAME);
            if (_playerCharacter == null)
                return false;

            _characterComponent = _playerCharacter.GetComponent<Character>();
            if (_characterComponent == null)
            {
                _logger.Warning("AutoPot: Character component not found.");
                return false;
            }

            InitializeHealthState();
            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InitializeHealthState()
        {
            int currentHealth = _characterComponent.Health;
            _monitorState.LastHealthValue = currentHealth;
            _monitorState.PreviousStableHealth = currentHealth;
            _monitorState.MaxHealth = currentHealth;
            _logger.Msg($"AutoPot: Initial max health set to {_monitorState.MaxHealth}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Update()
        {
            HandleToggleInput();

            if (!_autoPotEnabled)
                return;

            if (!ValidatePlayerState())
                return;

            float currentTime = Time.realtimeSinceStartup;
            if (currentTime - _lastHealthCheckTime >= HEALTH_CHECK_INTERVAL)
            {
                ProcessHealthCheck();
                _lastHealthCheckTime = currentTime;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void HandleToggleInput()
        {
            if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) &&
                Input.GetKeyDown(_currentAutoPotToggleKey))
            {
                _autoPotEnabled = !_autoPotEnabled;
                _logger.Msg($"AutoPot toggled {(_autoPotEnabled ? "ON" : "OFF")}.");
                _soundManager.PlayAutoPotToggleSound(_autoPotEnabled);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool ValidatePlayerState()
        {
            if (_playerCharacter != null && _playerCharacter.activeSelf)
                return !_gracePeriodActive;

            _playerCharacter = GameObject.Find(ModDefaults.PLAYER_OBJECT_NAME);
            if (_playerCharacter == null)
                return false;

            _characterComponent = _playerCharacter.GetComponent<Character>();
            if (_characterComponent != null)
            {
                _logger.Msg("Player reconnected. Starting grace period...");
                StartGracePeriod(ModDefaults.GRACE_PERIOD_DEFAULT);
                return false;
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ProcessHealthCheck()
        {
            if (_isSimulatingKeyPress)
                return;

            int currentHealth = _characterComponent.Health;
            

            HealthMonitoringHelper.UpdateStability(_monitorState, currentHealth, HEALTH_CHECK_INTERVAL, ModDefaults.HEALTH_STABILITY_TIME, _logger);
            
            float healthRatio = _monitorState.MaxHealth > 0 ? (float)currentHealth / _monitorState.MaxHealth : 1f;
            if (currentHealth > _monitorState.MaxHealth)
            {
                _monitorState.MaxHealth = currentHealth;
                _logger.Msg($"AutoPot: Max health updated to {_monitorState.MaxHealth}");
            }


            if (!_gracePeriodActive && 
                healthRatio <= _config.AutoPotHealthThreshold.Value && 
                _monitorState.HealthDropRate < -0.1f)
            {
                _logger.Msg($"AutoPot: Health is low ({currentHealth}/{_monitorState.MaxHealth} = {healthRatio:P}) and dropping at {_monitorState.HealthDropRate:F2}/s. Using health potion.");
                MelonCoroutines.Start(SimulateKeyPress());
            }
        }

        private IEnumerator SimulateKeyPress()
        {
            _isSimulatingKeyPress = true;
            
            KeyDown(_autoPotKey);
            yield return new WaitForSeconds(0.1f);
            KeyUp(_autoPotKey);

            yield return new WaitForSeconds(AUTO_POT_DELAY);
            _logger.Msg("AutoPot: Health potion key press simulation complete.");
            _isSimulatingKeyPress = false;
        }

        private void StartGracePeriod(float duration)
        {
            _gracePeriodActive = true;
            _logger.Msg($"Grace period: {duration}s");
            MelonCoroutines.Start(GracePeriodCooldown(duration));
        }

        private IEnumerator GracePeriodCooldown(float duration)
        {
            yield return new WaitForSecondsRealtime(duration);
            _gracePeriodActive = false;
            _logger.Msg("Grace period ended.");
        }

        #region keybd_event Interop
        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, System.UIntPtr dwExtraInfo);

        private const uint KEYEVENTF_KEYDOWN = 0x0;
        private const uint KEYEVENTF_KEYUP = 0x2;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void KeyDown(byte vk)
        {
            keybd_event(vk, 0, KEYEVENTF_KEYDOWN, System.UIntPtr.Zero);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void KeyUp(byte vk)
        {
            keybd_event(vk, 0, KEYEVENTF_KEYUP, System.UIntPtr.Zero);
        }
        #endregion
    }
}