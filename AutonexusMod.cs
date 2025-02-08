using MelonLoader;
using AutoNexus.Configuration;
using AutoNexus.Features;
using AutoNexus.Utils;
using HarmonyLib;
using HarmonyInstance = HarmonyLib.Harmony;

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
        private SpeedHack speedHack;

        public override void OnInitializeMelon()
        {
            config = new ModConfig();
            config.Initialize(LoggerInstance);

            soundManager = new SoundManager(LoggerInstance);
            roofRemover = new RoofRemover(LoggerInstance);
            autoNexus = new Features.AutoNexus(config, LoggerInstance);
            cameraController = new CameraController(config, LoggerInstance, roofRemover);
            keyboardController = new KeyboardController(config, LoggerInstance, soundManager);
            nameChanger = new NameChanger(config, LoggerInstance, "Character(Clone)");
            antiAFK = new AntiAFK(LoggerInstance);
            autoPot = new AutoPot(LoggerInstance, config, soundManager);
            speedHack = new SpeedHack(config, LoggerInstance);
            LoggerInstance.Msg("AutoNexus Mod Initialized.");

            var harmony = new HarmonyInstance("com.yourname.autonexusmod");
            harmony.PatchAll();
            LoggerInstance.Msg("Harmony patches applied.");
        }
        
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            roofRemover.RemoveRoofs();

            speedHack?.Reset();
        }

        public override void OnUpdate()
        {
            nameChanger?.Update();
            keyboardController.Update();
            cameraController.Update();
            antiAFK?.Update();
            autoPot?.Update();
            autoNexus?.Update();
            speedHack?.Update();
        }

        public override void OnApplicationQuit()
        {

            speedHack?.Reset();
            cameraController?.Reset();
            roofRemover.Stop();
        }
    }
}