using System;
using System.Collections;
using Il2Cpp;
using MelonLoader;
using UnityEngine;

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
        }

        private static MelonPreferences_Category _config;
        private static MelonPreferences_Entry<float> _healthThreshold;
        private static MelonPreferences_Entry<float> _updateInterval;
        private static MelonPreferences_Entry<float> _gracePeriodLowHealth;
        private static MelonPreferences_Entry<float> _gracePeriodDefault;
        private static MelonPreferences_Entry<float> _initCheckInterval;
        private static MelonPreferences_Entry<float> _healthStabilityTime;

        private const string PLAYER_OBJECT_NAME = "Character(Clone)";

        private GameObject _playerCharacter;
        private Character _characterComponent;
        private int _maxHealth = -1;
        private bool _gracePeriodActive;
        private bool _isMonitoringActive;
        private object _monitoringCoroutine;

        // Health stability tracking
        private int _lastHealthValue = -1;
        private float _healthStableTimer = 0f;
        private bool _isTrackingHealth = false;
        private bool _isHealthIncreasing = false;
        private int _previousStableHealth = -1;

        public override void OnInitializeMelon()
        {
            InitializeConfig();
            LoggerInstance.Msg("AutoNexus Mod Initialized.");
            MelonCoroutines.Start(InitializePlayer());
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

            // Log current settings
            LoggerInstance.Msg("=== AutoNexus Settings ===");
            LoggerInstance.Msg($"Health Threshold: {_healthThreshold.Value * 100}%");
            LoggerInstance.Msg($"Update Interval: {_updateInterval.Value}s");
            LoggerInstance.Msg($"Grace Period (Low Health): {_gracePeriodLowHealth.Value}s");
            LoggerInstance.Msg($"Grace Period (Default): {_gracePeriodDefault.Value}s");
            LoggerInstance.Msg($"Init Check Interval: {_initCheckInterval.Value}s");
            LoggerInstance.Msg($"Health Stability Time: {_healthStabilityTime.Value}s");
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

                LoggerInstance.Msg("Waiting for player character...");
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
                LoggerInstance.Msg($"Health: {currentHealth}/{_maxHealth}");
            }

            UpdateHealthStability(currentHealth);

            if (ShouldTriggerNexus(currentHealth))
            {
                LoggerInstance.Warning($"Critical health: {currentHealth}/{_maxHealth}");
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
                && currentHealth > 0
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
    }
}