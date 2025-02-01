using System;
using System.Collections;
using Il2Cpp;
using MelonLoader;
using UnityEngine;
using System.Runtime.InteropServices;
using Il2CppSystem;

namespace AutoNexus
{
    public class AutonexusMod : MelonMod
    {
        private static class Defaults
        {
            public const float HEALTH_THRESHOLD = 0.2f;
            public const float UPDATE_INTERVAL = 0.010f;
            public const float GRACE_PERIOD_LOW_HEALTH = 6f;
            public const float GRACE_PERIOD_DEFAULT = 4.5f;
            public const float INIT_CHECK_INTERVAL = 5f;
            public const float HEALTH_STABILITY_TIME = 2f;
            public const string DISCONNECT_KEY = "F";
            public const string TOGGLE_CHAT_KEY = "Return";
            public const string NEW_PLAYER_GUI_NAME = "Juix love me again please";
            public const float DEFAULT_PIXELS_PER_UNIT = 8f;
            public const float PIXELS_PER_UNIT_STEP = 0.5f;
            public const float MIN_PIXELS_PER_UNIT = 2f;
            public const float MAX_PIXELS_PER_UNIT = 20f;
            public const string DEFAULT_ZOOM_IN_KEY = "MouseScrollUp";
            public const string DEFAULT_ZOOM_OUT_KEY = "MouseScrollDown";
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
        private static MelonPreferences_Entry<string> _playerName;
        private static MelonPreferences_Entry<float> _pixelsPerUnit;
        private static MelonPreferences_Entry<float> _pixelsPerUnitStep;
        private static MelonPreferences_Entry<float> _minPixelsPerUnit;
        private static MelonPreferences_Entry<float> _maxPixelsPerUnit;
        private static MelonPreferences_Entry<string> _zoomInKey;
        private static MelonPreferences_Entry<string> _zoomOutKey;

        private const string PLAYER_OBJECT_NAME = "Character(Clone)";

        private GameObject _playerCharacter;
        private Character _characterComponent;
        private WorldCamera _worldCamera;
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
        private KeyCode _currentZoomInKey;
        private KeyCode _currentZoomOutKey;
        private float _lastUsedPixelsPerUnit;
        private bool _hasInitializedZoom = false;


        private bool _isChatMode = false;
        private bool _isDisconnectEnabled = true;

        private const uint SND_ASYNC = 0x0001;
        private const uint SND_FILENAME = 0x00020000;

        [DllImport("winmm.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool PlaySound(string pszSound, System.IntPtr hmod, uint fdwSound);

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
            ListenForFOVAdjustments();
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

            _playerName = _config.CreateEntry("PlayerName", Defaults.NEW_PLAYER_GUI_NAME,
                description: "Custom name for the player");

            _pixelsPerUnit = _config.CreateEntry("PixelsPerUnit", Defaults.DEFAULT_PIXELS_PER_UNIT,
                description: "Default zoom level (lower = farther view, higher = closer).");

            _pixelsPerUnitStep = _config.CreateEntry("PixelsPerUnitStep", Defaults.PIXELS_PER_UNIT_STEP,
                description: "How much to increase/decrease zoom per key press.");

            _minPixelsPerUnit = _config.CreateEntry("MinPixelsPerUnit", Defaults.MIN_PIXELS_PER_UNIT,
                description: "Minimum zoom out limit.");

            _maxPixelsPerUnit = _config.CreateEntry("MaxPixelsPerUnit", Defaults.MAX_PIXELS_PER_UNIT,
                description: "Maximum zoom in limit.");

            _zoomInKey = _config.CreateEntry("ZoomInKey", Defaults.DEFAULT_ZOOM_IN_KEY,
                description: "Key to zoom in (default: MouseScrollDown).");

            _zoomOutKey = _config.CreateEntry("ZoomOutKey", Defaults.DEFAULT_ZOOM_OUT_KEY,
                description: "Key to zoom out (default: MouseScrollUp).");

            LoggerInstance.Msg("=== Customization Settings ===");
            LoggerInstance.Msg($"Player Name: {_playerName.Value}");
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
            LoggerInstance.Msg("=== Camera Settings ===");
            LoggerInstance.Msg($"Default PixelsPerUnit: {_pixelsPerUnit.Value}");
            LoggerInstance.Msg($"PixelsPerUnit Step: {_pixelsPerUnitStep.Value}");
            LoggerInstance.Msg($"Min PixelsPerUnit: {_minPixelsPerUnit.Value}");
            LoggerInstance.Msg($"Max PixelsPerUnit: {_maxPixelsPerUnit.Value}");
            LoggerInstance.Msg($"Zoom In Key: {_zoomInKey.Value}");
            LoggerInstance.Msg($"Zoom Out Key: {_zoomOutKey.Value}");
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
            if (_playerCharacter == null)
                return false;

            _characterComponent = _playerCharacter.GetComponent<Character>();
            if (_characterComponent == null)
            {
                LoggerInstance.Warning("Character component not found.");
                return false;
            }

            var entity = _playerCharacter.GetComponent<Il2Cpp.Entity>();
            if (entity != null)
            {
                LoggerInstance.Msg($"Setting entity name and GUI name to: {_playerName.Value}");
                entity.SetEntityName(_playerName.Value);
                entity.SetEntityGuiName(_playerName.Value);
            }
            else
            {
                LoggerInstance.Warning("Entity component not found on player character during initialization.");
            }

            LoggerInstance.Msg($"Player character initialized with custom name: {_playerName.Value}");
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
                catch (System.Exception ex)
                {
                    LoggerInstance.Error($"Health monitoring error: {ex.Message}");
                    StopHealthMonitoring();
                }

                yield return waitInterval;
            }
        }
        private bool ValidatePlayerState()
        {
            if (_playerCharacter != null && _playerCharacter.activeSelf)
                return true;

            _playerCharacter = GameObject.Find(PLAYER_OBJECT_NAME);
            if (_playerCharacter == null)
                return false;

            _characterComponent = _playerCharacter.GetComponent<Character>();
            LoggerInstance.Msg("Player reconnected. Starting grace period...");

            _worldCamera = null;

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
            catch (System.Exception ex)
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
                _currentDisconnectKey = (KeyCode)System.Enum.Parse(typeof(KeyCode), keyString, ignoreCase: true);
            }
            catch (System.ArgumentException)
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
                _currentToggleChatKey = (KeyCode)System.Enum.Parse(typeof(KeyCode), keyString, ignoreCase: true);
            }
            catch (System.ArgumentException)
            {
                LoggerInstance.Error($"Invalid KeyCode '{_toggleChatKey.Value}' in config. Reverting to default key 'Enter'.");
                _currentToggleChatKey = KeyCode.Return;
                _toggleChatKey.Value = Defaults.TOGGLE_CHAT_KEY;
            }
        }
        private void PlaySoundFile(bool isEnabled)
        {
            string soundFilePath = isEnabled ? "Mods/sounds/enable.wav" : "Mods/sounds/disable.wav";

            if (System.IO.File.Exists(soundFilePath))
            {
                if (!PlaySound(soundFilePath, System.IntPtr.Zero, SND_ASYNC))
                {
                    LoggerInstance.Error($"Failed to play sound file: {soundFilePath}");
                }
            }
            else
            {
                LoggerInstance.Error($"Sound file not found: {soundFilePath}");
            }
        }


        private void ListenForFOVAdjustments()
        {
            if (_worldCamera == null)
            {
                _worldCamera = UnityEngine.Object.FindObjectOfType<WorldCamera>();
                if (_worldCamera == null)
                {
                    return;
                }

                if (!_hasInitializedZoom)
                {
                    _lastUsedPixelsPerUnit = _pixelsPerUnit.Value;
                    _hasInitializedZoom = true;
                }
                _worldCamera.PixelsPerUnit = _lastUsedPixelsPerUnit;
                LoggerInstance.Msg($"Applied saved camera zoom: PixelsPerUnit = {_lastUsedPixelsPerUnit}");
            }

            float newPixelsPerUnit = _worldCamera.PixelsPerUnit;
            bool adjustmentMade = false;

            float scrollDelta = Input.mouseScrollDelta.y;
            if (scrollDelta != 0)
            {
                if ((scrollDelta > 0 && _zoomInKey.Value.ToUpper() == "MOUSESCROLLUP") ||
                    (scrollDelta < 0 && _zoomOutKey.Value.ToUpper() == "MOUSESCROLLDOWN"))
                {
                    newPixelsPerUnit += _pixelsPerUnitStep.Value * Mathf.Sign(scrollDelta);
                    adjustmentMade = true;
                }
            }

            if (_currentZoomInKey != KeyCode.None && Input.GetKeyDown(_currentZoomInKey))
            {
                newPixelsPerUnit += _pixelsPerUnitStep.Value;
                adjustmentMade = true;
            }
            else if (_currentZoomOutKey != KeyCode.None && Input.GetKeyDown(_currentZoomOutKey))
            {
                newPixelsPerUnit -= _pixelsPerUnitStep.Value;
                adjustmentMade = true;
            }

            if (adjustmentMade)
            {
                newPixelsPerUnit = Mathf.Clamp(newPixelsPerUnit, _minPixelsPerUnit.Value, _maxPixelsPerUnit.Value);
                if (System.Math.Abs(newPixelsPerUnit - _worldCamera.PixelsPerUnit) > 0.01f)
                {
                    _worldCamera.PixelsPerUnit = newPixelsPerUnit;
                    _lastUsedPixelsPerUnit = newPixelsPerUnit;
                    LoggerInstance.Msg($"Camera Zoom Updated: PixelsPerUnit = {newPixelsPerUnit}");
                }
            }
        }
    }
}
