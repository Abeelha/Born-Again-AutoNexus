using MelonLoader;

namespace AutoNexus.Helpers
{
    public class HealthMonitorState
    {
        public int LastHealthValue { get; set; } = -1;
        public float HealthStableTimer { get; set; } = 0f;
        public bool IsTrackingHealth { get; set; } = false;
        public int PreviousStableHealth { get; set; } = -1;
        public int MaxHealth { get; set; } = -1;
    }

    public static class HealthMonitoringHelper
    {
        public static void UpdateStability(HealthMonitorState state, int currentHealth, float deltaTime, float stabilityTime, MelonLogger.Instance logger)
        {
            if (state.LastHealthValue == -1)
            {
                state.LastHealthValue = currentHealth;
                state.PreviousStableHealth = currentHealth;
                state.MaxHealth = currentHealth;
                return;
            }
            if (currentHealth != state.LastHealthValue)
            {
                state.LastHealthValue = currentHealth;
                state.HealthStableTimer = 0f;
                state.IsTrackingHealth = true;
                return;
            }
            if (state.IsTrackingHealth)
            {
                state.HealthStableTimer += deltaTime;
                if (state.HealthStableTimer >= stabilityTime)
                {
                    state.IsTrackingHealth = false;
                    if (currentHealth != state.PreviousStableHealth)
                    {
                        state.PreviousStableHealth = currentHealth;
                        state.MaxHealth = currentHealth;
                        logger.Msg($"Max Health Updated: {state.MaxHealth} (stable for {stabilityTime}s)");
                    }
                }
            }
        }
        public static void CheckCriticalHealth(int currentHealth, int maxHealth, float threshold, MelonLogger.Instance logger)
        {
            if (currentHealth <= maxHealth * threshold)
            {
                logger.Warning($"Critical health: {currentHealth}/{maxHealth}");
            }
        }
    }
}
