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
        public float HealthStableTimer { get; set; } = 0f;
        public bool IsTrackingHealth { get; set; } = false;
        public int PreviousStableHealth { get; set; } = -1;
        public int MaxHealth { get; set; } = -1;
        

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
        public void AddHealthReading(float health, float time)
        {
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
        private static readonly float[] _healthChangeThresholds = { 0.05f, 0.1f, 0.15f };

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void UpdateStability(HealthMonitorState state, int currentHealth, float deltaTime, float stabilityTime, MelonLogger.Instance logger)
        {
            float currentTime = Time.realtimeSinceStartup;


            if (state.LastHealthValue == -1)
            {
                InitializeState(state, currentHealth);
                return;
            }


            if (HasSignificantHealthChange(state.LastHealthValue, currentHealth))
            {
                ProcessHealthChange(state, currentHealth, currentTime, stabilityTime, logger);
            }


            state.AddHealthReading(currentHealth, currentTime);
            

            UpdateStabilityTimer(state, currentHealth, deltaTime, stabilityTime, logger);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool HasSignificantHealthChange(int lastHealth, int currentHealth)
        {
            if (lastHealth <= 0) return true;
            
            float changePercent = Math.Abs(currentHealth - lastHealth) / (float)lastHealth;
            return changePercent >= _healthChangeThresholds[0];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void InitializeState(HealthMonitorState state, int currentHealth)
        {
            state.LastHealthValue = currentHealth;
            state.PreviousStableHealth = currentHealth;
            state.MaxHealth = currentHealth;
            state.AddHealthReading(currentHealth, Time.realtimeSinceStartup);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ProcessHealthChange(HealthMonitorState state, int currentHealth, float currentTime, float stabilityTime, MelonLogger.Instance logger)
        {
            state.LastHealthValue = currentHealth;
            state.HealthStableTimer = 0f;
            state.IsTrackingHealth = true;


            if (currentHealth > state.MaxHealth)
            {
                state.MaxHealth = currentHealth;
                logger.Msg($"New max health detected: {currentHealth}");
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void UpdateStabilityTimer(HealthMonitorState state, int currentHealth, float deltaTime, float stabilityTime, MelonLogger.Instance logger)
        {
            if (!state.IsTrackingHealth) return;

            state.HealthStableTimer += deltaTime;
            if (state.HealthStableTimer >= stabilityTime)
            {
                state.IsTrackingHealth = false;
                if (currentHealth != state.PreviousStableHealth)
                {
                    state.PreviousStableHealth = currentHealth;
                    logger.Msg($"Health stabilized at: {currentHealth} (stable for {stabilityTime}s)");
                }
            }
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