using MelonLoader;
using AutoNexus.Constants;

namespace AutoNexus.Configuration
{
    public class ModConfig
    {
        private MelonPreferences_Category _config;

        public MelonPreferences_Entry<float> HealthThreshold { get; private set; }
        public MelonPreferences_Entry<float> UpdateInterval { get; private set; }
        public MelonPreferences_Entry<float> GracePeriodLowHealth { get; private set; }
        public MelonPreferences_Entry<float> GracePeriodDefault { get; private set; }
        public MelonPreferences_Entry<float> InitCheckInterval { get; private set; }
        public MelonPreferences_Entry<float> HealthStabilityTime { get; private set; }
        public MelonPreferences_Entry<string> DisconnectKey { get; private set; }
        public MelonPreferences_Entry<string> ToggleChatKey { get; private set; }
        public MelonPreferences_Entry<string> PlayerName { get; private set; }
        public MelonPreferences_Entry<float> PixelsPerUnit { get; private set; }
        public MelonPreferences_Entry<float> PixelsPerUnitStep { get; private set; }
        public MelonPreferences_Entry<float> MinPixelsPerUnit { get; private set; }
        public MelonPreferences_Entry<float> MaxPixelsPerUnit { get; private set; }
        public MelonPreferences_Entry<string> ZoomInKey { get; private set; }
        public MelonPreferences_Entry<string> ZoomOutKey { get; private set; }

        public void Initialize(MelonLogger.Instance logger)
        {
            _config = MelonPreferences.CreateCategory("AutoNexus");

            InitializeHealthSettings();
            InitializeKeyBindings();
            InitializePlayerSettings();
            InitializeCameraSettings();

            LogSettings(logger);
        }

        private void InitializeHealthSettings()
        {
            HealthThreshold = _config.CreateEntry("HealthThreshold", ModDefaults.HEALTH_THRESHOLD,
                description: "Percentage of health (0.2 = 20%) at which to trigger nexus");
            UpdateInterval = _config.CreateEntry("UpdateInterval", ModDefaults.UPDATE_INTERVAL,
                description: "How often to check health (in seconds)");
            GracePeriodLowHealth = _config.CreateEntry("GracePeriodLowHealth", ModDefaults.GRACE_PERIOD_LOW_HEALTH,
                description: "Grace period duration for low health (in seconds)");
            GracePeriodDefault = _config.CreateEntry("GracePeriodDefault", ModDefaults.GRACE_PERIOD_DEFAULT,
                description: "Default grace period duration (in seconds)");
            InitCheckInterval = _config.CreateEntry("InitCheckInterval", ModDefaults.INIT_CHECK_INTERVAL,
                description: "How often to check for player initialization (in seconds)");
            HealthStabilityTime = _config.CreateEntry("HealthStabilityTime", ModDefaults.HEALTH_STABILITY_TIME,
                description: "Time health needs to be stable to update max health (in seconds)");
        }

        private void InitializeKeyBindings()
        {
            DisconnectKey = _config.CreateEntry("DisconnectKey", ModDefaults.DISCONNECT_KEY,
                description: "Key to press for manual disconnect");
            ToggleChatKey = _config.CreateEntry("ToggleChatKey", ModDefaults.TOGGLE_CHAT_KEY,
                description: "Key to press to toggle chat mode");
        }

        private void InitializePlayerSettings()
        {
            PlayerName = _config.CreateEntry("PlayerName", ModDefaults.NEW_PLAYER_GUI_NAME,
                description: "Custom name for the player");
        }

        private void InitializeCameraSettings()
        {
            PixelsPerUnit = _config.CreateEntry("PixelsPerUnit", ModDefaults.Camera.DEFAULT_PIXELS_PER_UNIT,
                description: "Default zoom level");
            PixelsPerUnitStep = _config.CreateEntry("PixelsPerUnitStep", ModDefaults.Camera.PIXELS_PER_UNIT_STEP,
                description: "How much to increase/decrease zoom per key press");
            MinPixelsPerUnit = _config.CreateEntry("MinPixelsPerUnit", ModDefaults.Camera.MIN_PIXELS_PER_UNIT,
                description: "Minimum zoom out limit");
            MaxPixelsPerUnit = _config.CreateEntry("MaxPixelsPerUnit", ModDefaults.Camera.MAX_PIXELS_PER_UNIT,
                description: "Maximum zoom in limit");
            ZoomInKey = _config.CreateEntry("ZoomInKey", ModDefaults.Camera.DEFAULT_ZOOM_IN_KEY,
                description: "Key to zoom in");
            ZoomOutKey = _config.CreateEntry("ZoomOutKey", ModDefaults.Camera.DEFAULT_ZOOM_OUT_KEY,
                description: "Key to zoom out");
        }

        private void LogSettings(MelonLogger.Instance logger)
        {
            logger.Msg("=== Customization Settings ===");
            logger.Msg($"Player Name: {PlayerName.Value}");
            logger.Msg("=== AutoNexus Settings ===");
            logger.Msg($"Health Threshold: {HealthThreshold.Value * 100}%");
            logger.Msg($"Update Interval: {UpdateInterval.Value}s");
            logger.Msg($"Grace Period (Low Health): {GracePeriodLowHealth.Value}s");
            logger.Msg($"Grace Period (Default): {GracePeriodDefault.Value}s");
            logger.Msg($"Init Check Interval: {InitCheckInterval.Value}s");
            logger.Msg($"Health Stability Time: {HealthStabilityTime.Value}s");
            logger.Msg($"Disconnect Key: {DisconnectKey.Value}");
            logger.Msg($"Toggle Chat Key: {ToggleChatKey.Value}");
            logger.Msg("=== Camera Settings ===");
            logger.Msg($"Default PixelsPerUnit: {PixelsPerUnit.Value}");
            logger.Msg($"PixelsPerUnit Step: {PixelsPerUnitStep.Value}");
            logger.Msg($"Min PixelsPerUnit: {MinPixelsPerUnit.Value}");
            logger.Msg($"Max PixelsPerUnit: {MaxPixelsPerUnit.Value}");
            logger.Msg($"Zoom In Key: {ZoomInKey.Value}");
            logger.Msg($"Zoom Out Key: {ZoomOutKey.Value}");
            logger.Msg("For a list of KeyCodes, visit: https://docs.unity3d.com/ScriptReference/KeyCode.html");
        }
    }
}