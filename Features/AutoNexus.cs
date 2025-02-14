using UnityEngine;
using AutoNexus.Configuration;
using MelonLoader;
using System.Collections;
using AutoNexus.Constants;
using AutoNexus.Helpers;
using Il2Cpp;
using System.Runtime.CompilerServices;
using Il2CppRonin.Model.Enums;
using Il2CppZero.Game.Client;

namespace AutoNexus.Features
{
    public class AutoNexus
    {
        private readonly ModConfig _config;
        private readonly MelonLogger.Instance _logger;
        private GameObject _playerCharacter;
        private Character _characterComponent;
        private Entity _entityComponent;
        private Il2CppRonin.Model.Structs.Stats _entityStats;
        private readonly HealthMonitorState _monitorState = HealthMonitoringHelper.SharedState;

        private bool _gracePeriodActive;
        private bool _isMonitoringActive;
        private object _monitoringCoroutine;
        private int _waitingLogCounter = 0;
        private const int MAX_WAITING_LOGS = 3;

        private float _lastUpdateTime;
        private float _accumulatedTime;
        private const float MIN_UPDATE_INTERVAL = 1f / 165f;

        public AutoNexus(ModConfig config, MelonLogger.Instance logger)
        {
            _config = config;
            _logger = logger;
            _lastUpdateTime = Time.realtimeSinceStartup;
            StartInitialization();
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

            _entityComponent = _playerCharacter.GetComponent<Il2Cpp.Entity>();
            if (_entityComponent == null)
            {
                _logger.Warning("Entity component not found.");
                return false;
            }

            InitializeHealthState();
            InitializeEntityName();
            return true;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void InitializeHealthState()
        {
            int currentHealth = _characterComponent.Health;
            _monitorState.LastHealthValue = currentHealth;
    
            int statsMaxHealth = _entityComponent.GetStatFunctional(StatType.MaxHealth);
    
            _monitorState.UpdateMaxHealth(statsMaxHealth, _logger);
        }

        private void InitializeEntityName()
        {
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
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Update()
        {
            if (!_isMonitoringActive || _characterComponent == null)
                return;

            float currentTime = Time.realtimeSinceStartup;
            float deltaTime = currentTime - _lastUpdateTime;
            _lastUpdateTime = currentTime;

            _accumulatedTime += deltaTime;

            if (_accumulatedTime >= MIN_UPDATE_INTERVAL)
            {
                if (!ValidatePlayerState())
                    return;

                try
                {
                    int maxHealth = _entityComponent.GetStatFunctional(StatType.MaxHealth);
                    _monitorState.UpdateMaxHealth(maxHealth, _logger);
        
                    int currentHealth = _characterComponent.Health;
                    HealthMonitoringHelper.UpdateHealth(_monitorState, currentHealth, Time.realtimeSinceStartup);
                    HealthMonitoringHelper.CheckCriticalHealth(currentHealth, _monitorState.MaxHealth, _config.HealthThreshold.Value, _logger);
        
                    if (HealthMonitoringHelper.ShouldTriggerNexus(_config.HealthThreshold.Value, _gracePeriodActive))
                    {
                        DisconnectFromWorld();
                    }
                }
                catch (System.Exception ex)
                {
                    _logger.Error($"Health monitoring error: {ex.Message}");
                    StopHealthMonitoring();
                }

                _accumulatedTime = 0f;
            }

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void StartHealthMonitoring()
        {
            if (_isMonitoringActive)
                return;

            _isMonitoringActive = true;
            _logger.Msg("Starting health monitoring...");
            _monitoringCoroutine = MelonCoroutines.Start(MonitorPlayerHealth());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void StopHealthMonitoring()
        {
            if (!_isMonitoringActive)
                return;

            _isMonitoringActive = false;
            if (_monitoringCoroutine != null)
            {
                MelonCoroutines.Stop(_monitoringCoroutine);
                _monitoringCoroutine = null;
            }
        }

        private IEnumerator MonitorPlayerHealth()
        {
            var waitInterval = new WaitForSeconds(MIN_UPDATE_INTERVAL);
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

                _entityComponent = _playerCharacter.GetComponent<Il2Cpp.Entity>();
                if (_entityComponent != null)
                {
                    int maxHealth = _entityComponent.GetStatFunctional(StatType.MaxHealth);
                    _monitorState.UpdateMaxHealth(maxHealth, _logger);
                }

                StartGracePeriod(ModDefaults.GRACE_PERIOD_DEFAULT);
                return true;
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ProcessHealthCheck(ref int lastLoggedHealth)
        {
            int currentHealth = _characterComponent.Health;
            int maxHealth = _entityComponent.GetStatFunctional(StatType.MaxHealth);
            _monitorState.UpdateMaxHealth(maxHealth, _logger);

            if (currentHealth != lastLoggedHealth)
            {
                lastLoggedHealth = currentHealth;
                HealthMonitoringHelper.CheckCriticalHealth(currentHealth, _monitorState.MaxHealth, _config.HealthThreshold.Value, _logger);
            }

            if (HealthMonitoringHelper.ShouldTriggerNexus(_config.HealthThreshold.Value, _gracePeriodActive))
            {
                DisconnectFromWorld();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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