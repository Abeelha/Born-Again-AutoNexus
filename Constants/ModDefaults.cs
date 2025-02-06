namespace AutoNexus.Constants
{
    public static class ModDefaults
    {
        public const float HEALTH_THRESHOLD = 0.2f;
        public const float GRACE_PERIOD_DEFAULT = 4.5f;
        public const float INIT_CHECK_INTERVAL = 5f;
        public const float HEALTH_STABILITY_TIME = 2f;
        public const string DISCONNECT_KEY = "F";
        public const string TOGGLE_CHAT_KEY = "Return";
        public const string NEW_PLAYER_GUI_NAME = "Custom Name :D";
        public const string PLAYER_OBJECT_NAME = "Character(Clone)";

        public const float AUTO_POT_HEALTH_THRESHOLD = 0.40f;
        public const string AUTO_POT_KEY = "1";

        public static class Camera
        {
            public const float DEFAULT_PIXELS_PER_UNIT = 8f;
            public const float PIXELS_PER_UNIT_STEP = 0.5f;
            public const float MIN_PIXELS_PER_UNIT = 2f;
            public const float MAX_PIXELS_PER_UNIT = 20f;
            public const string DEFAULT_ZOOM_IN_KEY = "MouseScrollUp";
            public const string DEFAULT_ZOOM_OUT_KEY = "MouseScrollDown";
        }

        public static class Sound
        {
            public const uint SND_ASYNC = 0x0001;
            public const uint SND_FILENAME = 0x00020000;
        }
    }
}