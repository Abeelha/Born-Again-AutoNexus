using System.Runtime.CompilerServices;
using MelonLoader;
using UnityEngine;

namespace AutoNexus.Helpers
{
    public class HealthMonitorState
    {
        private const int HISTORY_SIZE = 30;
        private const int POTION_HISTORY_SIZE = 10;
        private const int DAMAGE_HISTORY_SIZE = 20;
        private const float DAMAGE_WINDOW = 3f;
        private const float BURST_DAMAGE_THRESHOLD = 0.20f;
        private readonly float[] _damageHistory;
        private readonly float[] _damageTimestamps;
        private readonly float[] _healthHistory;
        private readonly float[] _potionEffectivenessHistory;
        private readonly float[] _potionTimestamps;
        private readonly float[] _timeHistory;
        private int _damageHistoryIndex;

        private int _historyIndex;
        private int _potionHistoryIndex;

        public HealthMonitorState()
        {
            _healthHistory = new float[HISTORY_SIZE];
            _timeHistory = new float[HISTORY_SIZE];
            _potionEffectivenessHistory = new float[POTION_HISTORY_SIZE];
            _potionTimestamps = new float[POTION_HISTORY_SIZE];
            _damageHistory = new float[DAMAGE_HISTORY_SIZE];
            _damageTimestamps = new float[DAMAGE_HISTORY_SIZE];
            LastHealthCheckTime = Time.realtimeSinceStartup;
        }

        public int LastHealthValue { get; set; } = -1;
        public int MaxHealth { get; private set; } = -1;
        public float LastHealthCheckTime { get; private set; }
        public float HealthDropRate { get; private set; }
        public bool IsHealthCritical { get; internal set; }
        public float AverageHealthRecovery { get; private set; }
        public float RecentDamageIntensity { get; private set; }
        public bool IsBurstDamageDetected { get; private set; }

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
            float previousHealth = LastHealthValue;
            LastHealthValue = (int)health;

            if (health < previousHealth && previousHealth != -1)
            {
                RecordDamage(previousHealth - health, time);
            }

            _healthHistory[_historyIndex] = health;
            _timeHistory[_historyIndex] = time;
            _historyIndex = (_historyIndex + 1) % HISTORY_SIZE;

            CalculateHealthDropRate();
            UpdateDamageIntensity(time);
            DetectBurstDamage();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void RecordDamage(float damageAmount, float time)
        {
            _damageHistory[_damageHistoryIndex] = damageAmount;
            _damageTimestamps[_damageHistoryIndex] = time;
            _damageHistoryIndex = (_damageHistoryIndex + 1) % DAMAGE_HISTORY_SIZE;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void RecordPotionUse(float healthBefore, float healthAfter, float time)
        {
            float recovered = healthAfter - healthBefore;
            _potionEffectivenessHistory[_potionHistoryIndex] = recovered;
            _potionTimestamps[_potionHistoryIndex] = time;
            _potionHistoryIndex = (_potionHistoryIndex + 1) % POTION_HISTORY_SIZE;

            UpdatePotionEffectiveness();
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
                float longTermDropRate = healthDelta / timeDelta;

                float recentDropRate = CalculateRecentHealthDrop();

                HealthDropRate = Math.Min(longTermDropRate, recentDropRate);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private float CalculateRecentHealthDrop()
        {
            if (_historyIndex < 2) return 0f;

            int currentIndex = (_historyIndex - 1 + HISTORY_SIZE) % HISTORY_SIZE;
            float currentTime = _timeHistory[currentIndex];

            for (int i = 1; i < HISTORY_SIZE; i++)
            {
                int index = (_historyIndex - i + HISTORY_SIZE) % HISTORY_SIZE;
                if (currentTime - _timeHistory[index] > 1f)
                {
                    float healthDelta = _healthHistory[currentIndex] - _healthHistory[index];
                    float timeDelta = _timeHistory[currentIndex] - _timeHistory[index];
                    return healthDelta / timeDelta;
                }
            }

            return 0f;
        }

        private void UpdateDamageIntensity(float currentTime)
        {
            float recentDamage = 0f;
            for (int i = 0; i < DAMAGE_HISTORY_SIZE; i++)
            {
                if (currentTime - _damageTimestamps[i] <= DAMAGE_WINDOW)
                {
                    recentDamage += _damageHistory[i];
                }
            }

            RecentDamageIntensity = recentDamage / DAMAGE_WINDOW;
        }

        private void DetectBurstDamage()
        {
            if (MaxHealth <= 0) return;

            float burstThreshold = MaxHealth * BURST_DAMAGE_THRESHOLD;
            IsBurstDamageDetected = RecentDamageIntensity > burstThreshold;
        }

        private void UpdatePotionEffectiveness()
        {
            float totalRecovery = 0f;
            int validPotions = 0;
            float currentTime = Time.realtimeSinceStartup;

            for (int i = 0; i < POTION_HISTORY_SIZE; i++)
            {
                if (currentTime - _potionTimestamps[i] <= 30f)
                {
                    totalRecovery += _potionEffectivenessHistory[i];
                    validPotions++;
                }
            }

            if (validPotions > 0)
            {
                AverageHealthRecovery = totalRecovery / validPotions;
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
        public static void CheckCriticalHealth(int currentHealth, int maxHealth, float threshold,
            MelonLogger.Instance logger)
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
            bool isBurstDamage = SharedState.IsBurstDamageDetected;

            float currentHealthRatio = SharedState.LastHealthValue / (float)SharedState.MaxHealth;

            if (isBurstDamage && currentHealthRatio <= healthThreshold * 2f)
            {
                return true;
            }

            return isHealthCritical || (isDroppingFast && currentHealthRatio <= healthThreshold * 1.5f);
        }
    }
}