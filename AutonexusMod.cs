using System;
using System.Collections;
using Il2Cpp;
using MelonLoader;
using UnityEngine;

namespace AutoNexus
{
    public class AutonexusMod : MelonMod
    {
        private const float HEALTH_THRESHOLD = 0.2f;  // 20% health threshold
        private const float UPDATE_INTERVAL = 0.01667f;  // ~60 FPS
        private const float GRACE_PERIOD_LOW_HEALTH = 6f;
        private const float GRACE_PERIOD_DEFAULT = 3f;
        private const int MAX_INIT_RETRIES = 500;
        private const string PLAYER_OBJECT_NAME = "Character(Clone)";

        private GameObject _playerCharacter;
        private Character _characterComponent;
        private int _maxHealth = -1;
        private bool _gracePeriodActive;
        private bool _isMonitoringActive;
        private object _monitoringCoroutine;

        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("AutoNexus Mod Initialized.");
            MelonCoroutines.Start(InitializePlayer());
        }

        private IEnumerator InitializePlayer()
        {
            for (int retry = 0; retry < MAX_INIT_RETRIES; retry++)
            {
                if (TryInitializePlayer())
                {
                    StartHealthMonitoring();
                    yield break;
                }

                if (retry % 10 == 0)
                {
                    LoggerInstance.Warning($"Player initialization attempt {retry + 1}/{MAX_INIT_RETRIES}...");
                }

                yield return new WaitForSeconds(1f);
            }

            LoggerInstance.Error("Failed to initialize player after maximum retries.");
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
            var waitInterval = new WaitForSeconds(UPDATE_INTERVAL);
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
            StartGracePeriod(GRACE_PERIOD_DEFAULT);
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

            UpdateMaxHealth(currentHealth);

            if (ShouldTriggerNexus(currentHealth))
            {
                LoggerInstance.Warning($"Critical health: {currentHealth}/{_maxHealth}");
                DisconnectFromWorld();
            }
        }

        private void UpdateMaxHealth(int currentHealth)
        {
            if (_maxHealth == -1 || currentHealth > _maxHealth)
            {
                _maxHealth = currentHealth;
                LoggerInstance.Msg($"Max Health Updated: {_maxHealth}");
            }
        }

        private bool ShouldTriggerNexus(int currentHealth)
        {
            return !_gracePeriodActive
                && currentHealth > 0
                && _maxHealth > 0
                && currentHealth <= _maxHealth * HEALTH_THRESHOLD;
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