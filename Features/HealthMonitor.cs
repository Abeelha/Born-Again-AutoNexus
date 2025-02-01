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
        private object _monitoringCoroutine;
        private int _lastHealthValue = -1;
        private float _healthStableTimer = 0f;
        private bool _isTrackingHealth = false;
        private bool _isHealthIncreasing = false;
        private int _previousStableHealth = -1;
        private int _waitingLogCounter = 0;
        private const int MAX_WAITING_LOGS = 3;

        public HealthMonitor(ModConfig config, MelonLogger.Instance logger)
        {
            _config = config;
            _logger = logger;
            StartInitialization();
        }

        private void StartInitialization()
        {
            MelonCoroutines.Start(InitializePlayer());
        }

        private IEnumerator InitializePlayer()
        {
            var waitInterval = new WaitForSeconds(_config.InitCheckInterval.Value);

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
                _logger.Warning("Character component not found.");
                return false;
            }

            var entity = _playerCharacter.GetComponent<Il2Cpp.Entity>();
            if (entity != null)
            {
                _logger.Msg($"Setting entity name and GUI name to: {_config.PlayerName.Value}");
                entity.SetEntityName(_config.PlayerName.Value);
                entity.SetEntityGuiName(_config.PlayerName.Value);
            }
            else
            {
                _logger.Warning("Entity component not found on player character during initialization.");
            }

            _logger.Msg($"Player character initialized with custom name: {_config.PlayerName.Value}");
            return true;
        }

        private void StartHealthMonitoring()
        {
            if (_isMonitoringActive) return;

            _isMonitoringActive = true;
            _logger.Msg("Starting health monitoring...");
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
            var waitInterval = new WaitForSeconds(_config.UpdateInterval.Value);
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
                    _logger.Error($"Health monitoring error: {ex.Message}");
                    StopHealthMonitoring();
                }

                yield return waitInterval;
            }
        }

        private bool ValidatePlayerState()
        {
            if (_playerCharacter != null && _playerCharacter.activeSelf)
                return true;

            _playerCharacter = GameObject.Find(ModDefaults.PLAYER_OBJECT_NAME);
            if (_playerCharacter == null)
                return false;

            _characterComponent = _playerCharacter.GetComponent<Character>();
            _logger.Msg("Player reconnected. Starting grace period...");
            StartGracePeriod(_config.GracePeriodDefault.Value);
            return true;
        }

        private void ProcessHealthCheck(ref int lastLoggedHealth)
        {
            int currentHealth = _characterComponent.Health;

            if (currentHealth != lastLoggedHealth)
            {
                lastLoggedHealth = currentHealth;

                if (currentHealth <= _maxHealth * _config.HealthThreshold.Value)
                {
                    _logger.Warning($"Critical health: {currentHealth}/{_maxHealth}");
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
                _healthStableTimer += _config.UpdateInterval.Value;

                if (_healthStableTimer >= _config.HealthStabilityTime.Value)
                {
                    _isTrackingHealth = false;

                    if (currentHealth != _previousStableHealth)
                    {
                        _previousStableHealth = currentHealth;
                        _maxHealth = currentHealth;
                        _logger.Msg($"Max Health Updated: {_maxHealth} (stable for {_config.HealthStabilityTime.Value}s)");
                    }
                }
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
            yield return new WaitForSeconds(duration);
            _gracePeriodActive = false;
            _logger.Msg("Grace period ended.");
        }
    }
}