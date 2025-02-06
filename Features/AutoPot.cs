using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using MelonLoader;
using Il2Cpp;
using AutoNexus.Configuration;
using AutoNexus.Constants;
using AutoNexus.Helpers;

namespace AutoNexus.Features
{
    public class AutoPot
    {
        private readonly MelonLogger.Instance _logger;
        private readonly ModConfig _config;
        private GameObject _playerCharacter;
        private Character _characterComponent;
        private HealthMonitorState _monitorState = HealthMonitoringHelper.SharedState;
        private bool _isSimulatingKeyPress;
        private byte _autoPotKey;
        private bool _gracePeriodActive;

        private const float MIN_UPDATE_INTERVAL = 1f / 165f;

        public AutoPot(MelonLogger.Instance logger, ModConfig config)
        {
            _logger = logger;
            _config = config;
            ParseAutoPotKey();
            StartInitialization();
        }

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

            int currentHealth = _characterComponent.Health;
            _monitorState.LastHealthValue = currentHealth;
            _monitorState.PreviousStableHealth = currentHealth;
            _monitorState.MaxHealth = currentHealth;

            _logger.Msg($"AutoPot: Initial max health set to {_monitorState.MaxHealth}");
            return true;
        }

        public void Update()
        {
            if (!ValidatePlayerState())
                return;

            HealthMonitoringHelper.UpdateStability(_monitorState, _characterComponent.Health, MIN_UPDATE_INTERVAL, ModDefaults.HEALTH_STABILITY_TIME, _logger);
            ProcessHealthCheck();
        }

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

        private void ProcessHealthCheck()
        {
            int currentHealth = _characterComponent.Health;
            float healthRatio = _monitorState.MaxHealth > 0 ? (float)currentHealth / _monitorState.MaxHealth : 1f;

            if (!_gracePeriodActive && healthRatio <= _config.AutoPotHealthThreshold.Value && !_isSimulatingKeyPress)
            {
                _logger.Msg($"AutoPot: Health is low ({currentHealth}/{_monitorState.MaxHealth} = {healthRatio:P}). Using health potion.");
                MelonCoroutines.Start(SimulateKeyPress());
            }

            if (currentHealth > _monitorState.MaxHealth)
            {
                _monitorState.MaxHealth = currentHealth;
                _logger.Msg($"AutoPot: Max health updated to {_monitorState.MaxHealth}");
            }
        }

        private IEnumerator SimulateKeyPress()
        {
            _isSimulatingKeyPress = true;
            
            KeyDown(_autoPotKey);
            yield return new WaitForSeconds(0.1f);
            KeyUp(_autoPotKey);

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

        private void KeyDown(byte vk)
        {
            keybd_event(vk, 0, KEYEVENTF_KEYDOWN, System.UIntPtr.Zero);
        }

        private void KeyUp(byte vk)
        {
            keybd_event(vk, 0, KEYEVENTF_KEYUP, System.UIntPtr.Zero);
        }
        #endregion
    }
}
