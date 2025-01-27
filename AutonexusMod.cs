using System;
using System.Collections;
using Il2Cpp;
using MelonLoader;
using UnityEngine;

namespace AutoNexus
{
    public class AutonexusMod : MelonMod
    {
        private GameObject _playerCharacter;
        private readonly float _updateInterval = 0.01667f; // 16.67ms for 60 FPS
        private int _maxHealth = -1;
        private bool _gracePeriodActive = false;
        private bool _newWorldInstance = false;
        private readonly float _gracePeriodDurationLowHealth = 6f;
        private readonly float _gracePeriodDurationDefault = 10f;

        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("AutoNexus Mod Initialized.");
            MelonCoroutines.Start(WaitForPlayerInitialization());
        }

        private IEnumerator WaitForPlayerInitialization()
        {
            const int maxRetries = 50;
            int retryCount = 0;

            while (_playerCharacter == null && retryCount < maxRetries)
            {
                _playerCharacter = GameObject.Find("Character(Clone)");

                if (_playerCharacter != null)
                {
                    LoggerInstance.Msg($"Player character found: {_playerCharacter.name}");
                    LoggerInstance.Msg("Starting health monitoring...");
                    _newWorldInstance = true;
                    MelonCoroutines.Start(MonitorPlayerHealth());
                    yield break;
                }

                retryCount++;
                LoggerInstance.Warning($"Waiting for player character to initialize... Retry {retryCount}/{maxRetries}");
                yield return new WaitForSeconds(1f);
            }

            if (_playerCharacter == null)
                LoggerInstance.Error("Player character could not be initialized after maximum retries.");
        }

        private IEnumerator MonitorPlayerHealth()
        {
            int lastLoggedHealth = -1;

            while (true)
            {
                if (_playerCharacter == null || !_playerCharacter.activeSelf)
                {
                    _playerCharacter = GameObject.Find("Character(Clone)");
                    if (_playerCharacter == null)
                    {
                        LoggerInstance.Warning("Player character not found. Retrying...");
                        yield return new WaitForSeconds(_updateInterval);
                        continue;
                    }
                }

                try
                {
                    var character = _playerCharacter.GetComponent<Character>();
                    if (character != null)
                    {
                        int currentHealth = character.Health;

                        if (currentHealth != lastLoggedHealth)
                        {
                            lastLoggedHealth = currentHealth;
                            LoggerInstance.Msg($"Player Health: {currentHealth}/{_maxHealth}");
                        }

                        if (_newWorldInstance)
                        {
                            float graceDuration = (currentHealth <= _maxHealth * 0.3f)
                                ? _gracePeriodDurationLowHealth
                                : _gracePeriodDurationDefault;

                            StartGracePeriod(graceDuration, currentHealth);
                            _newWorldInstance = false;
                        }

                        if (_maxHealth == -1 || currentHealth > _maxHealth)
                        {
                            _maxHealth = currentHealth;
                            LoggerInstance.Msg($"Max Health Updated: {_maxHealth}");
                        }

                        if (!_gracePeriodActive && currentHealth <= _maxHealth * 0.2f && currentHealth > 0)
                        {
                            LoggerInstance.Warning($"Health critically low ({currentHealth}/{_maxHealth}). Disconnecting...");
                            DisconnectFromWorld();
                        }
                    }
                    else
                    {
                        LoggerInstance.Warning("Character component not found on the player GameObject.");
                    }
                }
                catch (Exception ex)
                {
                    LoggerInstance.Error($"Error while monitoring player health: {ex.Message}");
                }

                yield return new WaitForSeconds(_updateInterval);
            }
        }

        private void DisconnectFromWorld()
        {
            try
            {
                var world = UnityEngine.Object.FindObjectOfType<Il2Cpp.World>();
                if (world != null)
                {
                    LoggerInstance.Msg("Attempting to disconnect from the world...");
                    world.Disconnect();
                    LoggerInstance.Msg("Player successfully disconnected from the world.");
                }
                else
                {
                    LoggerInstance.Warning("World object not found.");
                }
            }
            catch (Exception ex)
            {
                LoggerInstance.Error($"Error while disconnecting from world: {ex.Message}");
            }
        }

        private void StartGracePeriod(float duration, int initialHealth)
        {
            _gracePeriodActive = true;
            LoggerInstance.Msg($"Grace period started for {duration} seconds...");
            MelonCoroutines.Start(GracePeriodCooldown(duration, initialHealth));
        }

        private IEnumerator GracePeriodCooldown(float duration, int initialHealth)
        {
            float elapsedTime = 0f;

            while (elapsedTime < duration)
            {
                var character = _playerCharacter?.GetComponent<Character>();
                if (character != null)
                {
                    int currentHealth = character.Health;

                    if (currentHealth > initialHealth)
                    {
                        LoggerInstance.Msg($"Health increased during grace period ({currentHealth} > {initialHealth}). AutoNexus reactivated.");
                        _gracePeriodActive = false;
                        yield break;
                    }
                }

                elapsedTime += _updateInterval;
                yield return new WaitForSeconds(_updateInterval);
            }

            _gracePeriodActive = false;
            LoggerInstance.Msg("Grace period ended. AutoNexus reactivated.");
        }
    }
}
