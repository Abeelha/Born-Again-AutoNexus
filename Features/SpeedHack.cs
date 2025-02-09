using UnityEngine;
using MelonLoader;
using AutoNexus.Configuration;
using System;

namespace AutoNexus.Features
{
    public class SpeedHack
    {
        private readonly MelonLogger.Instance _logger;
        private bool _isActive = false;
        private static float DefaultGameSpeed;
        private const float SpeedBoost = 0.070f;

        private KeyCode _toggleKey;
        private readonly ModConfig _config;

        public SpeedHack(ModConfig config, MelonLogger.Instance logger)
        {
            _logger = logger;
            _config = config;
            DefaultGameSpeed = Time.timeScale;

            _toggleKey = GetKeyCodeFromString(_config.SpeedHackKey.Value);

            _logger.Msg($"[SpeedHack] Default game speed detected: {DefaultGameSpeed}");
            _logger.Msg($"[SpeedHack] SpeedHack keybind set to: {_toggleKey}");
        }

        public void Update()
        {
            if (Input.GetKeyDown(_toggleKey))
            {
                ToggleSpeed();
            }
        }

        private void ToggleSpeed()
        {
            _isActive = !_isActive;
            float newSpeed = _isActive ? DefaultGameSpeed + SpeedBoost : DefaultGameSpeed;
            Time.timeScale = newSpeed;
            Time.fixedDeltaTime = (0.02f / DefaultGameSpeed) * Time.timeScale;

            _logger.Msg($"[SpeedHack] Toggled! New speed: {Time.timeScale}, FixedDeltaTime: {Time.fixedDeltaTime}");
        }

        private KeyCode GetKeyCodeFromString(string key)
        {
            if (Enum.TryParse(typeof(KeyCode), key, true, out object result))
            {
                return (KeyCode)result;
            }

            _logger.Warning($"[SpeedHack] Invalid key '{key}'. Defaulting to 'T'.");
            return KeyCode.T;
        }
    }
}