using UnityEngine;
using AutoNexus.Configuration;
using MelonLoader;
using System.Collections;
using AutoNexus.Constants;
using Il2Cpp;

namespace AutoNexus.Features
{
    public class HealthMonitor
    {
        private readonly ModConfig _config;
        private readonly MelonLogger.Instance _logger;
        private GameObject _playerCharacter;
        private Character _characterComponent;
        private int _maxHealth = -1;
        private bool _gracePeriodActive;
        private bool _isMonitoringActive;
        private int _lastHealthValue = -1;
        private float _healthStableTimer = 0f;
        private bool _isTrackingHealth = false;
        private int _previousStableHealth = -1;
        private int _waitingLogCounter = 0;
        private const int MAX_WAITING_LOGS = 3;

        private float _lastUpdateTime;
        private float _accumulatedTime;
        private const float MIN_UPDATE_INTERVAL = 1f / 165f;

        public HealthMonitor(ModConfig config, MelonLogger.Instance logger)
        {
            _config = config;
            _logger = logger;
            _lastUpdateTime = Time.realtimeSinceStartup;
            StartInitialization();
        }

        private void StartInitialization()
        {
            MelonCoroutines.Start(InitializePlayer());
        }

        private IEnumerator InitializePlayer()
        {
            while (true)
            {
                if (TryInitializePlayer())
                {
                    StartHealthMonitoring();
                    yield break;
                }

                if (_waitingLogCounter < MAX_WAITING_LOGS)
                {
                    _logger.Msg("Waiting for player character...");
                    _waitingLogCounter++;
                }
                yield return new WaitForSecondsRealtime(ModDefaults.INIT_CHECK_INTERVAL);
            }
        }

        private bool TryInitializePlayer()
        {
            _playerCharacter = GameObject.Find(ModDefaults.PLAYER_OBJECT_NAME);
            if (_playerCharacter == null) return false;

            _characterComponent = _playerCharacter.GetComponent<Character>();
            if (_characterComponent == null)
            {
                _logger.Warning("Character component not found.");
                return false;
            }

            var entity = _playerCharacter.GetComponent<Il2Cpp.Entity>();
            if (entity != null)
            {
                entity.SetEntityName(_config.PlayerName.Value);
                entity.SetEntityGuiName(_config.PlayerName.Value);
                _logger.Msg($"Player character initialized with custom name: {_config.PlayerName.Value}");
            }

            return true;
        }

        public void Update()
        {
            if (!_isMonitoringActive || _characterComponent == null) return;

            float currentTime = Time.realtimeSinceStartup;
            float deltaTime = currentTime - _lastUpdateTime;
            _lastUpdateTime = currentTime;

            _accumulatedTime += deltaTime;

            if (_accumulatedTime >= MIN_UPDATE_INTERVAL)
            {
                if (!ValidatePlayerState()) return;

                try
                {
                    ProcessHealthCheck();
                    UpdateHealthStability(deltaTime);
                }
                catch (System.Exception ex)
                {
                    _logger.Error($"Health monitoring error: {ex.Message}");
                    StopHealthMonitoring();
                }

                _accumulatedTime = 0f;
            }
        }

        private void StartHealthMonitoring()
        {
            if (_isMonitoringActive) return;
            _isMonitoringActive = true;
            _logger.Msg("Starting health monitoring...");
        }

        private void StopHealthMonitoring()
        {
            if (!_isMonitoringActive) return;
            _isMonitoringActive = false;
        }

        private bool ValidatePlayerState()
        {
            if (_playerCharacter != null && _playerCharacter.activeSelf)
                return true;

            _playerCharacter = GameObject.Find(ModDefaults.PLAYER_OBJECT_NAME);
            if (_playerCharacter == null)
                return false;

            _characterComponent = _playerCharacter.GetComponent<Character>();
            if (_characterComponent != null)
            {
                _logger.Msg("Player reconnected. Starting grace period...");
                StartGracePeriod(ModDefaults.GRACE_PERIOD_DEFAULT);
                return true;
            }
            return false;
        }

        private void ProcessHealthCheck()
        {
            int currentHealth = _characterComponent.Health;

            if (currentHealth != _lastHealthValue)
            {
                _lastHealthValue = currentHealth;

                if (currentHealth <= _maxHealth * _config.HealthThreshold.Value)
                {
                    _logger.Warning($"Critical health: {currentHealth}/{_maxHealth}");
                }
            }

            if (ShouldTriggerNexus(currentHealth))
            {
                DisconnectFromWorld();
            }
        }

        private void UpdateHealthStability(float deltaTime)
        {
            int currentHealth = _characterComponent.Health;

            if (_lastHealthValue == -1)
            {
                _lastHealthValue = currentHealth;
                _previousStableHealth = currentHealth;
                _maxHealth = currentHealth;
                return;
            }

            if (_isTrackingHealth)
            {
                _healthStableTimer += deltaTime;

                if (_healthStableTimer >= ModDefaults.HEALTH_STABILITY_TIME)
                {
                    _isTrackingHealth = false;

                    if (currentHealth != _previousStableHealth)
                    {
                        _previousStableHealth = currentHealth;
                        _maxHealth = currentHealth;
                        _logger.Msg($"Max Health Updated: {_maxHealth} (stable for {ModDefaults.HEALTH_STABILITY_TIME}s)");
                    }
                }
            }
            else if (currentHealth != _lastHealthValue)
            {
                _lastHealthValue = currentHealth;
                _healthStableTimer = 0f;
                _isTrackingHealth = true;
            }
        }

        private bool ShouldTriggerNexus(int currentHealth)
        {
            return !_gracePeriodActive 
                && _maxHealth > 0 
                && currentHealth <= _maxHealth * _config.HealthThreshold.Value;
        }

        private void DisconnectFromWorld()
        {
            try
            {
                var world = UnityEngine.Object.FindObjectOfType<Il2Cpp.World>();
                if (world == null)
                {
                    _logger.Warning("World object not found.");
                    return;
                }

                _logger.Msg("Disconnecting from world...");
                world.Disconnect();
                _logger.Msg("Disconnected successfully.");
            }
            catch (System.Exception ex)
            {
                _logger.Error($"Disconnect error: {ex.Message}");
            }
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
    }
}