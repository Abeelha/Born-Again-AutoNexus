using MelonLoader;
using AutoNexus.Configuration;
using AutoNexus.Features;
using AutoNexus.Utils;

namespace AutoNexus
{
    public class AutonexusMod : MelonMod
    {
        private ModConfig config;
        private Features.AutoNexus autoNexus;
        private CameraController cameraController;
        private RoofRemover roofRemover;
        private KeyboardController keyboardController;
        private SoundManager soundManager;
        private NameChanger nameChanger;
        private AntiAFK antiAFK;
        private AutoPot autoPot;

        public override void OnInitializeMelon()
        {
            config = new ModConfig();
            config.Initialize(LoggerInstance);

            soundManager = new SoundManager(LoggerInstance);
            autoNexus = new Features.AutoNexus(config, LoggerInstance);
            cameraController = new CameraController(config, LoggerInstance);
            roofRemover = new RoofRemover(LoggerInstance);
            keyboardController = new KeyboardController(config, LoggerInstance, soundManager);
            nameChanger = new NameChanger(config, LoggerInstance, "Character(Clone)");
            antiAFK = new AntiAFK(LoggerInstance);
            autoPot = new AutoPot(LoggerInstance, config, soundManager);
            LoggerInstance.Msg("AutoNexus Mod Initialized.");
        }

        public override void OnUpdate()
        {
            nameChanger?.Update();
            keyboardController.Update();
            cameraController.Update();
            antiAFK?.Update();
            autoPot?.Update();
            autoNexus?.Update();
        }

        public override void OnApplicationQuit()
        {
            cameraController?.Reset();
            roofRemover?.Reset();
        }
    }
}