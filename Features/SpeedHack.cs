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
        private const float SpeedBoost = 0.080f;
        private const float MaxAllowedSpeed = 1.080f;
        private const int DecimalPrecision = 3;
        
        private const float ResyncInterval = 0.305f;
        private const float ResyncDuration = 0.15f;
        private const float LongResyncInterval = 2.2f;
        private const float LongResyncDuration = 0.4f;
        
        private float _lastResyncTime = 0f;
        private float _lastLongResyncTime = 0f;
        private bool _isResyncing = false;
        private bool _isLongResyncing = false;
        private float _resyncEndTime = 0f;
        
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

            if (_isActive && !_isResyncing && !_isLongResyncing)
            {

                if (Time.time - _lastLongResyncTime >= LongResyncInterval)
                {
                    StartLongResync();
                }

                else if (Time.time - _lastResyncTime >= ResyncInterval)
                {
                    StartResync();
                }
            }


            if (_isResyncing && Time.time >= _resyncEndTime)
            {
                EndResync();
            }
            else if (_isLongResyncing && Time.time >= _resyncEndTime)
            {
                EndLongResync();
            }
        }

        private void StartResync()
        {
            _isResyncing = true;
            _resyncEndTime = Time.time + ResyncDuration;
            
            Time.timeScale = DefaultGameSpeed;
            Time.fixedDeltaTime = DefaultFixedDeltaTime;
            
            _logger.Msg("[SpeedHack] Starting quick resync...");
        }

        private void StartLongResync()
        {
            _isLongResyncing = true;
            _resyncEndTime = Time.time + LongResyncDuration;
            
            Time.timeScale = DefaultGameSpeed;
            Time.fixedDeltaTime = DefaultFixedDeltaTime;
            
            _logger.Msg("[SpeedHack] Starting long resync for stability...");
        }

        private void EndResync()
        {
            _isResyncing = false;
            _lastResyncTime = Time.time;
            
            Time.timeScale = MaxAllowedSpeed;
            Time.fixedDeltaTime = RoundToSignificantDigits(DefaultFixedDeltaTime / MaxAllowedSpeed);
            
            _logger.Msg("[SpeedHack] Quick resync complete");
        }

        private void EndLongResync()
        {
            _isLongResyncing = false;
            _lastLongResyncTime = Time.time;
            _lastResyncTime = Time.time;
            
            Time.timeScale = MaxAllowedSpeed;
            Time.fixedDeltaTime = RoundToSignificantDigits(DefaultFixedDeltaTime / MaxAllowedSpeed);
            
            _logger.Msg("[SpeedHack] Long resync complete");
        }

        private float RoundToSignificantDigits(float value)
        {
            return (float)Math.Round(value, DecimalPrecision);
        }

        private void ToggleSpeed()
        {
            _isActive = !_isActive;
            _isResyncing = false;
            _isLongResyncing = false;
            
            if (_isActive)
            {
                Time.timeScale = MaxAllowedSpeed;
                Time.fixedDeltaTime = RoundToSignificantDigits(DefaultFixedDeltaTime / MaxAllowedSpeed);
                _lastResyncTime = Time.time;
                _lastLongResyncTime = Time.time;
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

        public void Reset()
        {
            if (_isActive)
            {
                _isActive = false;
                _isResyncing = false;
                _isLongResyncing = false;
                Time.timeScale = DefaultGameSpeed;
                Time.fixedDeltaTime = DefaultFixedDeltaTime;
                _logger.Msg("[SpeedHack] Reset to default values");
            }
        }
    }
}