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
        private GameObject? _playerCharacter;
        private Character? _characterComponent;
        private readonly HealthMonitorState _monitorState = HealthMonitoringHelper.SharedState;
        private bool _isSimulatingKeyPress;
        private byte _autoPotKey;
        private bool _gracePeriodActive;
        private bool _autoPotEnabled = true;
        private KeyCode _currentAutoPotToggleKey;


        private const float MIN_UPDATE_INTERVAL = 1f / 165f;
        private const float AUTO_POT_DELAY = 0.25f;
        private const float HEALTH_CHECK_INTERVAL = 0.05f;
        private const float AGGRESSIVE_THRESHOLD = 0.6f;
        private const float RAPID_HEALTH_DROP_THRESHOLD = -50f;


        private const float POTION_COOLDOWN = 0.5f;
        private const float HEALING_EFFECTIVENESS_WINDOW = 0.3f;
        private float _lastPotTime;
        private float _lastHealthCheckTime;
        private float _healthBeforePot;
        private bool _isHealingEffective;
        private int _consecutivePotCount;
        private const int MAX_CONSECUTIVE_POTS = 3;
        private const float HEALING_THRESHOLD = 50f;


        private const float EMERGENCY_HEALTH_RATIO = 0.3f;
        private const float EMERGENCY_DROP_RATE = -150f;
        private const float DOUBLE_POT_THRESHOLD = 1.2f;

        public AutoPot(MelonLogger.Instance logger, ModConfig config, SoundManager soundManager)
        {
            _logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
            _config = config ?? throw new System.ArgumentNullException(nameof(config));
            _soundManager = soundManager ?? throw new System.ArgumentNullException(nameof(soundManager));
            _lastHealthCheckTime = Time.realtimeSinceStartup;
            _lastPotTime = -POTION_COOLDOWN;
            Initialize();
        }

        private void Initialize()
        {
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

        private void InitializeHealthState()
        {
            if (_characterComponent == null) return;
            
            int currentHealth = _characterComponent.Health;
            _monitorState.LastHealthValue = currentHealth;
            _monitorState.PreviousStableHealth = currentHealth;
            _monitorState.MaxHealth = currentHealth;
            _logger.Msg($"AutoPot: Initial max health set to {_monitorState.MaxHealth}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Update()
        {
            if (!HandleToggleInput()) return;
            if (!_autoPotEnabled) return;
            if (!ValidatePlayerState()) return;
            if (_characterComponent == null) return;

            float currentTime = Time.realtimeSinceStartup;
            if (currentTime - _lastHealthCheckTime >= HEALTH_CHECK_INTERVAL)
            {
                ProcessHealthCheck();
                _lastHealthCheckTime = currentTime;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool HandleToggleInput()
        {
            if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) &&
                Input.GetKeyDown(_currentAutoPotToggleKey))
            {
                _autoPotEnabled = !_autoPotEnabled;
                _logger.Msg($"AutoPot toggled {(_autoPotEnabled ? "ON" : "OFF")}.");
                _soundManager.PlayAutoPotToggleSound(_autoPotEnabled);
            }
            return true;
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
        private bool ShouldUsePotion(float healthRatio, float currentHealth)
        {
            if (_gracePeriodActive || _isSimulatingKeyPress)
                return false;

            float currentTime = Time.realtimeSinceStartup;
            float timeSinceLastPot = currentTime - _lastPotTime;


            if (timeSinceLastPot < POTION_COOLDOWN)
                return false;

            if (_consecutivePotCount >= MAX_CONSECUTIVE_POTS && timeSinceLastPot < POTION_COOLDOWN * 2)
            {
                _logger.Msg($"AutoPot: Limiting potion usage after {_consecutivePotCount} consecutive uses.");
                return false;
            }


            if (_monitorState.HealthDropRate < EMERGENCY_DROP_RATE && healthRatio < EMERGENCY_HEALTH_RATIO)
                return true;


            if (_isHealingEffective && timeSinceLastPot < HEALING_EFFECTIVENESS_WINDOW)
            {
                float healingAmount = currentHealth - _healthBeforePot;
                if (healingAmount >= HEALING_THRESHOLD)
                {
                    _logger.Msg($"AutoPot: Current healing is effective (+{healingAmount:F0} HP). Waiting.");
                    return false;
                }
            }


            bool belowThreshold = healthRatio <= _config.AutoPotHealthThreshold.Value;
            bool rapidDrop = _monitorState.HealthDropRate < RAPID_HEALTH_DROP_THRESHOLD;
            bool aggressiveMode = healthRatio <= AGGRESSIVE_THRESHOLD && rapidDrop;

            return belowThreshold || aggressiveMode;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ProcessHealthCheck()
        {
            if (_characterComponent == null) return;

            int currentHealth = _characterComponent.Health;
            float healthRatio = _monitorState.MaxHealth > 0 ? (float)currentHealth / _monitorState.MaxHealth : 1f;


            if (currentHealth > _monitorState.MaxHealth)
            {
                _monitorState.MaxHealth = currentHealth;
                _logger.Msg($"AutoPot: Max health updated to {_monitorState.MaxHealth}");
            }


            float timeSinceLastPot = Time.realtimeSinceStartup - _lastPotTime;
            if (timeSinceLastPot < HEALING_EFFECTIVENESS_WINDOW)
            {
                float healingAmount = currentHealth - _healthBeforePot;
                _isHealingEffective = healingAmount >= HEALING_THRESHOLD;
                
                if (_isHealingEffective)
                {
                    _consecutivePotCount = 0;
                }
            }


            if (ShouldUsePotion(healthRatio, currentHealth))
            {
                _healthBeforePot = currentHealth;
                _lastPotTime = Time.realtimeSinceStartup;
                _consecutivePotCount++;
                
                string reason = _monitorState.HealthDropRate < EMERGENCY_DROP_RATE ? "emergency" :
                               _monitorState.HealthDropRate < RAPID_HEALTH_DROP_THRESHOLD ? "rapid health drop" :
                               "below threshold";

                _logger.Msg($"AutoPot: Health is low ({currentHealth}/{_monitorState.MaxHealth} = {healthRatio:P2}) - {reason} - dropping at {_monitorState.HealthDropRate:F2}/s. Using health potion (#{_consecutivePotCount}).");
                MelonCoroutines.Start(SimulateKeyPress(healthRatio));
            }
            else if (timeSinceLastPot > POTION_COOLDOWN * 2)
            {
                _consecutivePotCount = 0;
            }
        }

        private IEnumerator SimulateKeyPress(float currentHealthRatio)
        {
            if (_isSimulatingKeyPress) yield break;
            
            _isSimulatingKeyPress = true;
            

            KeyDown(_autoPotKey);
            yield return new WaitForSeconds(0.05f);
            KeyUp(_autoPotKey);


            bool emergencyCondition = _monitorState.HealthDropRate < EMERGENCY_DROP_RATE && 
                                    currentHealthRatio <= _config.HealthThreshold.Value * DOUBLE_POT_THRESHOLD;
            
            if (emergencyCondition)
            {
                yield return new WaitForSeconds(0.15f);
                KeyDown(_autoPotKey);
                yield return new WaitForSeconds(0.05f);
                KeyUp(_autoPotKey);
                _logger.Msg("AutoPot: Emergency double-pot used.");
            }

            yield return new WaitForSeconds(AUTO_POT_DELAY);
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