using MelonLoader;
using AutoNexus.Configuration;
using AutoNexus.Features;
using AutoNexus.Utils;

namespace AutoNexus
{
    public class AutonexusMod : MelonMod
    {
        private ModConfig _config;
        private HealthMonitor _healthMonitor;
        private CameraController _cameraController;
        private KeyboardController _keyboardController;
        private SoundManager _soundManager;
        private NameChanger _nameChanger;

        public override void OnInitializeMelon()
        {
            GUI.Main(new string [] { });
            _config = new ModConfig();
            _config.Initialize(LoggerInstance);

            _soundManager = new SoundManager(LoggerInstance);
            _healthMonitor = new HealthMonitor(_config, LoggerInstance);
            _cameraController = new CameraController(_config, LoggerInstance);
            _keyboardController = new KeyboardController(_config, LoggerInstance, _soundManager);

            _nameChanger = new NameChanger(_config, LoggerInstance, "Character(Clone)");

            LoggerInstance.Msg("AutoNexus Mod Initialized.");
        }

        public override void OnUpdate()
        {
            _nameChanger?.Update();

            _keyboardController.Update();
            _cameraController.Update();
        }

        public override void OnApplicationQuit()
        {
            _cameraController?.Reset();
        }
    }
}
