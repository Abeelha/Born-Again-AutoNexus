using MelonLoader;
using AutoNexus.Configuration;
using AutoNexus.Features;
using AutoNexus.Utils;

namespace AutoNexus
{
    public class AutonexusMod : MelonMod
    {
        private ModConfig _config;
        private Features.AutoNexus _autoNexus;
        private CameraController _cameraController;
        private KeyboardController _keyboardController;
        private SoundManager _soundManager;
        private NameChanger _nameChanger;
        private AntiAFK _antiAFK;
        private AutoPot _autoPot;

        public override void OnInitializeMelon()
        {
            _config = new ModConfig();
            _config.Initialize(LoggerInstance);

            _soundManager = new SoundManager(LoggerInstance);
            _autoNexus = new Features.AutoNexus(_config, LoggerInstance);
            _cameraController = new CameraController(_config, LoggerInstance);
            _keyboardController = new KeyboardController(_config, LoggerInstance, _soundManager);
            _nameChanger = new NameChanger(_config, LoggerInstance, "Character(Clone)");
            _antiAFK = new AntiAFK(LoggerInstance);
            _autoPot = new AutoPot(LoggerInstance, _config);
            LoggerInstance.Msg("AutoNexus Mod Initialized.");
        }

        public override void OnUpdate()
        {
            _nameChanger?.Update();
            _keyboardController.Update();
            _cameraController.Update();
            _antiAFK?.Update();
            _autoPot?.Update();
            _autoNexus?.Update();
        }

        public override void OnApplicationQuit()
        {
            _cameraController?.Reset();
        }
    }
}