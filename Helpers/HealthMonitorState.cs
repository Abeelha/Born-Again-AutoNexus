using MelonLoader;
using UnityEngine;
using System;
using System.Runtime.CompilerServices;

namespace AutoNexus.Helpers
{
    public class HealthMonitorState
    {
        private readonly float[] _healthHistory;
        private readonly float[] _timeHistory;
        private int _historyIndex;
        private const int HISTORY_SIZE = 30;
    
        public int LastHealthValue { get; set; } = -1;
        public int MaxHealth { get; private set; } = -1;
        public float LastHealthCheckTime { get; private set; }
        public float HealthDropRate { get; private set; }
        public bool IsHealthCritical { get; internal set; }

        public HealthMonitorState()
        {
            _healthHistory = new float[HISTORY_SIZE];
            _timeHistory = new float[HISTORY_SIZE];
            LastHealthCheckTime = Time.realtimeSinceStartup;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void UpdateMaxHealth(int newMaxHealth, MelonLogger.Instance logger)
        {
            if (newMaxHealth <= 0) return;
        
            if (MaxHealth != newMaxHealth)
            {
                MaxHealth = newMaxHealth;
                logger.Msg($"Max health updated to: {MaxHealth}");
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddHealthReading(float health, float time)
        {
            LastHealthValue = (int)health;
            _healthHistory[_historyIndex] = health;
            _timeHistory[_historyIndex] = time;
            _historyIndex = (_historyIndex + 1) % HISTORY_SIZE;
        
            CalculateHealthDropRate();
        }

        private void CalculateHealthDropRate()
        {
            if (_historyIndex < 2) return;

            int prevIndex = (_historyIndex - 1 + HISTORY_SIZE) % HISTORY_SIZE;
            int oldestIndex = (_historyIndex - HISTORY_SIZE + 1 + HISTORY_SIZE) % HISTORY_SIZE;

            float timeDelta = _timeHistory[prevIndex] - _timeHistory[oldestIndex];
            if (timeDelta > float.Epsilon)
            {
                float healthDelta = _healthHistory[prevIndex] - _healthHistory[oldestIndex];
                HealthDropRate = healthDelta / timeDelta;
            }
        }
    }
    public static class HealthMonitoringHelper
    {
        public static readonly HealthMonitorState SharedState = new HealthMonitorState();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void UpdateHealth(HealthMonitorState state, int currentHealth, float currentTime)
        {
            state.AddHealthReading(currentHealth, currentTime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void CheckCriticalHealth(int currentHealth, int maxHealth, float threshold, MelonLogger.Instance logger)
        {
            if (maxHealth <= 0) return;
        
            float healthRatio = currentHealth / (float)maxHealth;
            bool isCritical = healthRatio <= threshold;
        
            if (isCritical)
            {
                logger.Warning($"Critical health: {currentHealth}/{maxHealth} ({healthRatio:P2})");
            }

            SharedState.IsHealthCritical = isCritical;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool ShouldTriggerNexus(float healthThreshold, bool gracePeriodActive)
        {
            if (gracePeriodActive || SharedState.MaxHealth <= 0) return false;

            bool isHealthCritical = SharedState.IsHealthCritical;
            bool isDroppingFast = SharedState.HealthDropRate < -0.2f;

            return isHealthCritical || (isDroppingFast && SharedState.LastHealthValue / (float)SharedState.MaxHealth <= healthThreshold * 1.5f);
        }
    }
}