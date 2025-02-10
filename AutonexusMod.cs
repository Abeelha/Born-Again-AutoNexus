using MelonLoader;
using AutoNexus.Configuration;
using AutoNexus.Features;
using AutoNexus.Utils;
using AutoNexus.UI;
using UnityEngine;

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
        private ConfigDisplay configDisplay;

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
            LoggerInstance.Msg("AutoNexus Mod Initialized.");
        }
        
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            roofRemover.RemoveRoofs();

            var canvas = GameObject.Find("Canvas")?.GetComponent<Canvas>();
            if (canvas != null)
            {
                if (configDisplay == null)
                {
                    configDisplay = new ConfigDisplay(config, LoggerInstance);
                }
                configDisplay.Initialize(canvas);
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