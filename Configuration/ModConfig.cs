using MelonLoader;
using AutoNexus.Constants;

namespace AutoNexus.Configuration
{
    public class ModConfig
    {
        private MelonPreferences_Category _config;

        public MelonPreferences_Entry<float> HealthThreshold { get; private set; }
        public MelonPreferences_Entry<string> DisconnectKey { get; private set; }
        public MelonPreferences_Entry<string> PlayerName { get; private set; }
        public MelonPreferences_Entry<string> ZoomInKey { get; private set; }
        public MelonPreferences_Entry<string> ZoomOutKey { get; private set; }
        public MelonPreferences_Entry<float> AutoPotHealthThreshold { get; private set; }
        public MelonPreferences_Entry<string> AutoPotKey { get; private set; }
        public MelonPreferences_Entry<string> AutoPotToggleKey { get; private set; }

        public void Initialize(MelonLogger.Instance logger)
        {
            _config = MelonPreferences.CreateCategory("AutoNexus");

            InitializeHealthSettings();
            InitializeKeyBindings();
            InitializePlayerSettings();
            InitializeCameraSettings();
            InitializeAutoPotSettings();

            LogSettings(logger);
        }

        private void InitializeHealthSettings()
        {
            HealthThreshold = _config.CreateEntry("HealthThreshold", ModDefaults.HEALTH_THRESHOLD,
                description: "Percentage of health (e.g., 0.20 = 20%) at which to trigger nexus");
        }

        private void InitializeKeyBindings()
        {
            DisconnectKey = _config.CreateEntry("DisconnectKey", ModDefaults.DISCONNECT_KEY,
                description: "Key to press for manual disconnect. Can be a single character, function key, or special key name.");
        }

        private void InitializePlayerSettings()
        {
            PlayerName = _config.CreateEntry("PlayerName", ModDefaults.NEW_PLAYER_GUI_NAME,
                description: "Custom name for the player");
        }

        private void InitializeCameraSettings()
        {
            ZoomInKey = _config.CreateEntry("ZoomInKey", ModDefaults.Camera.DEFAULT_ZOOM_IN_KEY,
                description: "Key to zoom in");
            ZoomOutKey = _config.CreateEntry("ZoomOutKey", ModDefaults.Camera.DEFAULT_ZOOM_OUT_KEY,
                description: "Key to zoom out");
        }

        private void InitializeAutoPotSettings()
        {
            AutoPotHealthThreshold = _config.CreateEntry("AutoPotHealthThreshold", ModDefaults.AUTO_POT_HEALTH_THRESHOLD,
                description: "Percentage of health (e.g., 0.40 = 40%) at which the AutoPot feature triggers");
            AutoPotKey = _config.CreateEntry("AutoPotKey", ModDefaults.AUTO_POT_KEY,
                description: "Key to press for AutoPot. Can be a letter, digit, function key, or special key name.");
            AutoPotToggleKey = _config.CreateEntry("AutoPotToggleKey", ModDefaults.AUTO_POT_TOGGLE_KEY,
                description: "Key to toggle the AutoPot feature on/off. Can be any valid key name.");
        }

        private void LogSettings(MelonLogger.Instance logger)
        {
            logger.Msg("=== Customization Settings ===");
            logger.Msg($"Player Name: {PlayerName.Value}");
            logger.Msg("=== AutoNexus Settings ===");
            logger.Msg($"Health Threshold: {HealthThreshold.Value * 100:F2}%");
            logger.Msg($"Init Check Interval (fixed): {ModDefaults.INIT_CHECK_INTERVAL}s");
            logger.Msg($"Grace Period (Default, fixed): {ModDefaults.GRACE_PERIOD_DEFAULT}s");
            logger.Msg($"Disconnect Key: {DisconnectKey.Value}");
            logger.Msg("=== Camera Settings ===");
            logger.Msg($"Zoom In Key: {ZoomInKey.Value}");
            logger.Msg($"Zoom Out Key: {ZoomOutKey.Value}");
            logger.Msg("=== AutoPot Settings ===");
            logger.Msg($"AutoPot Health Threshold: {AutoPotHealthThreshold.Value * 100:F2}%");
            logger.Msg($"AutoPot Key: {AutoPotKey.Value}");
            logger.Msg($"AutoPot Toggle Key: {AutoPotToggleKey.Value}");
            logger.Msg("For a list of KeyCodes, visit: https://docs.unity3d.com/ScriptReference/KeyCode.html");
        }
    }
}
