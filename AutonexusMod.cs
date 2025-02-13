using MelonLoader;
using AutoNexus.Configuration;
using AutoNexus.Features;
using AutoNexus.Utils;
using AutoNexus.UI;
using UnityEngine;
using System.Net;
using Il2Cpp;
using Il2CppZero.Game.Client;

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
            configDisplay = new ConfigDisplay(config, LoggerInstance, nameChanger);

            LoggerInstance.Msg("AutoNexus Mod Initialized.");
        }



        private static void Test()
        {
            RoninGameService roninGameService = new RoninGameService();
            ZeroClient client = roninGameService.Client; // Get the value

            client.UpdateState();
            //client._transferDelay = 0;
        }


        private static void UpdateSpam()
        {
            RoninGameService roninGameService = new RoninGameService();
            ZeroClient client = roninGameService.Client; // Get the value
            //Il2CppSystem.Net.IPAddress ipAddress = Il2CppSystem.Net.IPAddress.Parse("18.192.45.68");
            //string key = "IDuP6FWmtZmGvwhzncmD";
            //int port = 12000;

            for (int i = 0; i < 1000; i++)
            {
                client.Update(uint.MaxValue);
                client.SetConnected();
                client.SendData(uint.MaxValue);
                client.ReceiveData(uint.MaxValue);
                //client.Start(ipAddress, port, key);
            }
        }

        public static void ConnectSpam()
        {
            RoninGameService roninGameService = new RoninGameService();
            ZeroClient client = roninGameService.Client; // Get the value
            Il2CppSystem.Net.IPAddress ipAddress = Il2CppSystem.Net.IPAddress.Parse("18.192.45.68");
            string key = "IDuP6FWmtZmGvwhzncmD";
            int port = 12000;

            for (int i = 0; i < 1000; i++)
            {
                client.Start(ipAddress, port, key);
            }
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