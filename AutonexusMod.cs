using System;
using System.Collections;
using Il2Cpp;
using MelonLoader;
using UnityEngine;
using System.Runtime.InteropServices;

namespace AutoNexus
{
    public class AutonexusMod : MelonMod
    {
        private static class Defaults
        {
            public const float HEALTH_THRESHOLD = 0.2f;
            public const float UPDATE_INTERVAL = 0.01667f;
            public const float GRACE_PERIOD_LOW_HEALTH = 6f;
            public const float GRACE_PERIOD_DEFAULT = 3f;
            public const float INIT_CHECK_INTERVAL = 5f;
            public const float HEALTH_STABILITY_TIME = 2f;
            public const string DISCONNECT_KEY = "R";
            public const string TOGGLE_CHAT_KEY = "Return";
        }

        private static MelonPreferences_Category _config;
        private static MelonPreferences_Entry<float> _healthThreshold;
        private static MelonPreferences_Entry<float> _updateInterval;
        private static MelonPreferences_Entry<float> _gracePeriodLowHealth;
        private static MelonPreferences_Entry<float> _gracePeriodDefault;
        private static MelonPreferences_Entry<float> _initCheckInterval;
        private static MelonPreferences_Entry<float> _healthStabilityTime;
        private static MelonPreferences_Entry<string> _disconnectKey;
        private static MelonPreferences_Entry<string> _toggleChatKey;

        private const string PLAYER_OBJECT_NAME = "Character(Clone)";

        private GameObject _playerCharacter;
        private Character _characterComponent;
        private int _maxHealth = -1;
        private bool _gracePeriodActive;
        private bool _isMonitoringActive;
        private object _monitoringCoroutine;
        private int _lastHealthValue = -1;
        private float _healthStableTimer = 0f;
        private bool _isTrackingHealth = false;
        private bool _isHealthIncreasing = false;
        private int _previousStableHealth = -1;
        private int _waitingLogCounter = 0;
        private const int MAX_WAITING_LOGS = 3;
        private KeyCode _currentDisconnectKey = KeyCode.R;
        private KeyCode _currentToggleChatKey = KeyCode.Return;

        private bool _isChatMode = false;
        private bool _isDisconnectEnabled = true;

        [DllImport("winmm.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool PlaySound(string pszSound, IntPtr hmod, uint fdwSound);

        public override void OnInitializeMelon()
        {
            string soundsFolder = "Mods/sounds";
            if (!System.IO.Directory.Exists(soundsFolder))
            {
                System.IO.Directory.CreateDirectory(soundsFolder);
                LoggerInstance.Msg($"Created sounds folder at: {soundsFolder}");
            }
            InitializeConfig();
            LoggerInstance.Msg("AutoNexus Mod Initialized.");
            MelonCoroutines.Start(InitializePlayer());
        }

        public override void OnUpdate()
        {
            ListenForToggleChatKey();
            ListenForDisconnectKey();
            ListenForLockKey();
        }
        private void InitializeConfig()
        {
            _config = MelonPreferences.CreateCategory("AutoNexus");

            _healthThreshold = _config.CreateEntry("HealthThreshold", Defaults.HEALTH_THRESHOLD,
                description: "Percentage of health (0.2 = 20%) at which to trigger nexus");

            _updateInterval = _config.CreateEntry("UpdateInterval", Defaults.UPDATE_INTERVAL,
                description: "How often to check health (in seconds). 0.01667 = 60 FPS");

            _gracePeriodLowHealth = _config.CreateEntry("GracePeriodLowHealth", Defaults.GRACE_PERIOD_LOW_HEALTH,
                description: "Grace period duration for low health (in seconds)");

            _gracePeriodDefault = _config.CreateEntry("GracePeriodDefault", Defaults.GRACE_PERIOD_DEFAULT,
                description: "Default grace period duration (in seconds)");

            _initCheckInterval = _config.CreateEntry("InitCheckInterval", Defaults.INIT_CHECK_INTERVAL,
                description: "How often to check for player initialization (in seconds)");

            _healthStabilityTime = _config.CreateEntry("HealthStabilityTime", Defaults.HEALTH_STABILITY_TIME,
                description: "Time health needs to be stable to update max health (in seconds)");

            _disconnectKey = _config.CreateEntry("DisconnectKey", Defaults.DISCONNECT_KEY,
                description: "Key to press for manual disconnect (Refer to KeyCode list)");

            _toggleChatKey = _config.CreateEntry("ToggleChatKey", Defaults.TOGGLE_CHAT_KEY,
                description: "Key to press to toggle chat mode (Refer to KeyCode list)");

            LoggerInstance.Msg("=== AutoNexus Settings ===");
            LoggerInstance.Msg($"Health Threshold: {_healthThreshold.Value * 100}%");
            LoggerInstance.Msg($"Update Interval: {_updateInterval.Value}s");
            LoggerInstance.Msg($"Grace Period (Low Health): {_gracePeriodLowHealth.Value}s");
            LoggerInstance.Msg($"Grace Period (Default): {_gracePeriodDefault.Value}s");
            LoggerInstance.Msg($"Init Check Interval: {_initCheckInterval.Value}s");
            LoggerInstance.Msg($"Health Stability Time: {_healthStabilityTime.Value}s");
            LoggerInstance.Msg($"Disconnect Key: {_disconnectKey.Value}");
            LoggerInstance.Msg($"Toggle Chat Key: {_toggleChatKey.Value}");
            LoggerInstance.Msg("For a list of KeyCodes, visit: https://docs.unity3d.com/ScriptReference/KeyCode.html");
        }

        private void PlaySoundFile(bool isEnabled)
        {
            string soundFilePath = isEnabled ? "Mods/sounds/enable.wav" : "Mods/sounds/disable.wav";

            if (System.IO.File.Exists(soundFilePath))
            {
                if (!PlaySound(soundFilePath, IntPtr.Zero, SND_ASYNC))
                {
                    LoggerInstance.Error($"Failed to play sound file: {soundFilePath}");
                }
            }
            else
            {
                LoggerInstance.Error($"Sound file not found: {soundFilePath}");
            }
        }

        private IEnumerator InitializePlayer()
        {
            var waitInterval = new WaitForSeconds(_initCheckInterval.Value);

            while (true)
            {
                if (TryInitializePlayer())
                {
                    StartHealthMonitoring();
                    yield break;
                }

                if (_waitingLogCounter < MAX_WAITING_LOGS)
                {
                    LoggerInstance.Msg("Waiting for player character...");
                    _waitingLogCounter++;
                }
                yield return waitInterval;
            }
        }
        private bool TryInitializePlayer()
        {
            _playerCharacter = GameObject.Find(PLAYER_OBJECT_NAME);
            if (_playerCharacter == null) return false;

            _characterComponent = _playerCharacter.GetComponent<Character>();
            if (_characterComponent == null)
            {
                LoggerInstance.Warning("Character component not found.");
                return false;
            }

            LoggerInstance.Msg($"Player character initialized: {_playerCharacter.name}");
            return true;
        }

        private void StartHealthMonitoring()
        {
            if (_isMonitoringActive) return;

            _isMonitoringActive = true;
            LoggerInstance.Msg("Starting health monitoring...");
            _monitoringCoroutine = MelonCoroutines.Start(MonitorPlayerHealth());
        }

        private void StopHealthMonitoring()
        {
            if (!_isMonitoringActive) return;

            _isMonitoringActive = false;
            if (_monitoringCoroutine != null)
            {
                MelonCoroutines.Stop(_monitoringCoroutine);
                _monitoringCoroutine = null;
            }
        }

        private IEnumerator MonitorPlayerHealth()
        {
            var waitInterval = new WaitForSeconds(_updateInterval.Value);
            int lastLoggedHealth = -1;

            while (_isMonitoringActive)
            {
                if (!ValidatePlayerState())
                {
                    yield return waitInterval;
                    continue;
                }

                try
                {
                    ProcessHealthCheck(ref lastLoggedHealth);
                }
                catch (Exception ex)
                {
                    LoggerInstance.Error($"Health monitoring error: {ex.Message}");
                    StopHealthMonitoring();
                }

                yield return waitInterval;
            }
        }

        private bool ValidatePlayerState()
        {
            if (_playerCharacter != null && _playerCharacter.activeSelf) return true;

            _playerCharacter = GameObject.Find(PLAYER_OBJECT_NAME);
            if (_playerCharacter == null) return false;

            _characterComponent = _playerCharacter.GetComponent<Character>();
            LoggerInstance.Msg("Player reconnected. Starting grace period...");
            StartGracePeriod(_gracePeriodDefault.Value);
            return true;
        }

        private void ProcessHealthCheck(ref int lastLoggedHealth)
        {
            int currentHealth = _characterComponent.Health;

            if (currentHealth != lastLoggedHealth)
            {
                lastLoggedHealth = currentHealth;

                if (currentHealth <= _maxHealth * _healthThreshold.Value)
                {
                    LoggerInstance.Warning($"Critical health: {currentHealth}/{_maxHealth}");
                }
            }

            UpdateHealthStability(currentHealth);

            if (ShouldTriggerNexus(currentHealth))
            {
                DisconnectFromWorld();
            }
        }
        private void UpdateHealthStability(int currentHealth)
        {
            if (_lastHealthValue == -1)
            {
                _lastHealthValue = currentHealth;
                _previousStableHealth = currentHealth;
                _maxHealth = currentHealth;
                return;
            }

            if (_lastHealthValue != currentHealth)
            {
                _isHealthIncreasing = currentHealth > _lastHealthValue;
                _lastHealthValue = currentHealth;
                _healthStableTimer = 0f;
                _isTrackingHealth = true;
                return;
            }

            if (_isTrackingHealth)
            {
                _healthStableTimer += _updateInterval.Value;

                if (_healthStableTimer >= _healthStabilityTime.Value)
                {
                    _isTrackingHealth = false;

                    if (currentHealth != _previousStableHealth)
                    {
                        _previousStableHealth = currentHealth;
                        _maxHealth = currentHealth;
                        LoggerInstance.Msg($"Max Health Updated: {_maxHealth} (stable for {_healthStabilityTime.Value}s)");
                    }
                }
            }
        }
        private bool ShouldTriggerNexus(int currentHealth)
        {
            return !_gracePeriodActive
                && _maxHealth > 0
                && currentHealth <= _maxHealth * _healthThreshold.Value;
        }
        private void DisconnectFromWorld()
        {
            try
            {
                var world = UnityEngine.Object.FindObjectOfType<Il2Cpp.World>();
                if (world == null)
                {
                    LoggerInstance.Warning("World object not found.");
                    return;
                }

                LoggerInstance.Msg("Disconnecting from world...");
                world.Disconnect();
                LoggerInstance.Msg("Disconnected successfully.");
            }
            catch (Exception ex)
            {
                LoggerInstance.Error($"Disconnect error: {ex.Message}");
            }
        }
        private void StartGracePeriod(float duration)
        {
            _gracePeriodActive = true;
            LoggerInstance.Msg($"Grace period: {duration}s");
            MelonCoroutines.Start(GracePeriodCooldown(duration));
        }

        private IEnumerator GracePeriodCooldown(float duration)
        {
            yield return new WaitForSeconds(duration);
            _gracePeriodActive = false;
            LoggerInstance.Msg("Grace period ended.");
        }
        private void ListenForDisconnectKey()
        {
            UpdateDisconnectKey();

            if (!_isChatMode && _isDisconnectEnabled && Input.GetKeyDown(_currentDisconnectKey) &&
                !Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.RightControl))
            {
                LoggerInstance.Msg($"Disconnect key '{_currentDisconnectKey}' pressed. Initiating disconnect...");
                DisconnectFromWorld();
            }
        }

        private void ListenForToggleChatKey()
        {
            UpdateToggleChatKey();

            if (Input.GetKeyDown(_currentToggleChatKey))
            {
                _isChatMode = !_isChatMode;
                LoggerInstance.Msg($"Chat mode {(_isChatMode ? "enabled" : "disabled")}. Disconnect functionality is now {(!_isChatMode ? "active" : "inactive")}.");
            }
        }
        private void ListenForLockKey()
        {
            if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) && Input.GetKeyDown(_currentDisconnectKey))
            {
                _isDisconnectEnabled = !_isDisconnectEnabled;
                LoggerInstance.Msg($"Disconnect functionality is now {(_isDisconnectEnabled ? "enabled" : "disabled")}.");

                PlaySoundFile(_isDisconnectEnabled);
            }
        }
        private void UpdateDisconnectKey()
        {
            string keyString = _disconnectKey.Value.ToUpper();

            if (keyString == "ENTER")
            {
                keyString = "RETURN";
            }

            try
            {
                _currentDisconnectKey = (KeyCode)Enum.Parse(typeof(KeyCode), keyString, ignoreCase: true);
            }
            catch (ArgumentException)
            {
                LoggerInstance.Error($"Invalid KeyCode '{_disconnectKey.Value}' in config. Reverting to default key 'R'.");
                _currentDisconnectKey = KeyCode.R;
                _disconnectKey.Value = Defaults.DISCONNECT_KEY;
            }
        }
        private void UpdateToggleChatKey()
        {
            string keyString = _toggleChatKey.Value.ToUpper();

            if (keyString == "ENTER")
            {
                keyString = "RETURN";
            }

            try
            {
                _currentToggleChatKey = (KeyCode)Enum.Parse(typeof(KeyCode), keyString, ignoreCase: true);
            }
            catch (ArgumentException)
            {
                LoggerInstance.Error($"Invalid KeyCode '{_toggleChatKey.Value}' in config. Reverting to default key 'Enter'.");
                _currentToggleChatKey = KeyCode.Return;
                _toggleChatKey.Value = Defaults.TOGGLE_CHAT_KEY;
            }
        }
    }
}
