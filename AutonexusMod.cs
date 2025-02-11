using AutoNexus.Configuration;
using AutoNexus.Features;
using AutoNexus.UI;
using AutoNexus.Utils;
using MelonLoader;
using UnityEngine;

namespace AutoNexus
{
    public class AutonexusMod : MelonMod
    {
        private AntiAFK antiAFK;
        private Features.AutoNexus autoNexus;
        private AutoPot autoPot;
        private CameraController cameraController;
        private ModConfig config;
        private ConfigDisplay configDisplay;
        private KeyboardController keyboardController;
        private NameChanger nameChanger;
        private RoofRemover roofRemover;
        private SoundManager soundManager;

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
            configDisplay = new ConfigDisplay(config, LoggerInstance);

            LoggerInstance.Msg("AutoNexus Mod Initialized.");
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            roofRemover.RemoveRoofs();

            var canvas = GameObject.Find("Canvas")?.GetComponent<Canvas>();
            if (canvas != null)
            {
                configDisplay?.Initialize(canvas);
            }
            else
            {
                LoggerInstance.Error("Canvas not found in scene: " + sceneName);
            }
        }

        public override void OnUpdate()
        {
            nameChanger?.Update();
            keyboardController.Update();
            cameraController.Update();
            antiAFK?.Update();
            autoPot?.Update();
            autoNexus?.Update();
            configDisplay?.Update();
            configDisplay?.Update();

            if (Input.GetKeyDown(KeyCode.Insert))
            {
                configDisplay?.ToggleVisibility();
            }
        }

        public override void OnApplicationQuit()
        {
            cameraController?.Reset();
            roofRemover.Stop();
        }
    }
}