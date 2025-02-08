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
        private static float DefaultFixedDeltaTime;
        private const float SpeedBoost = 0.045f;
        private const float MaxAllowedSpeed = 1.045f;
        
        private KeyCode _toggleKey;
        private readonly ModConfig _config;

        public SpeedHack(ModConfig config, MelonLogger.Instance logger)
        {
            _logger = logger;
            _config = config;
            DefaultGameSpeed = Time.timeScale;
            DefaultFixedDeltaTime = Time.fixedDeltaTime;
            
            _toggleKey = GetKeyCodeFromString(_config.SpeedHackKey.Value);
            
            _logger.Msg($"[SpeedHack] Default game speed detected: {DefaultGameSpeed}");
            _logger.Msg($"[SpeedHack] Default fixedDeltaTime detected: {DefaultFixedDeltaTime}");
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
            
            if (_isActive)
            {
                Time.timeScale = MaxAllowedSpeed;
                Time.fixedDeltaTime = DefaultFixedDeltaTime / MaxAllowedSpeed;
            }
            else
            {
                Time.timeScale = DefaultGameSpeed;
                Time.fixedDeltaTime = DefaultFixedDeltaTime;
            }
            
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