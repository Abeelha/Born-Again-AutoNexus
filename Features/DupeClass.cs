using UnityEngine;
using MelonLoader;
using AutoNexus.Configuration;
using System;
using Il2Cpp;
using Il2CppZero.Game.Client;
using System.Collections;

namespace AutoNexus.Features
{
    public class DupeClass
    {
        private readonly MelonLogger.Instance _logger;
        private bool _isActive = false;
        private static RoninGameService roninGameService;
        private static ZeroClient client;


        private KeyCode _toggleKey;
        private readonly ModConfig _config;

        public DupeClass(ModConfig config, MelonLogger.Instance logger)
        {
            _logger = logger;
            _config = config;

            _toggleKey = KeyCode.V;

            _logger.Msg($"[Dupe] Dupe keybind set to: {_toggleKey}");
        }

        public void Update()
        {
            if (Input.GetKeyDown(_toggleKey))
            {
                var roninsvc = UnityEngine.Object.FindObjectOfType<Il2Cpp.RoninGameService>();

                for (int i = 0; i < 3; i++)
                {
                    roninsvc.EnsureRunningOnMainThread();
                    roninsvc.Client.SetConnected();
                    roninsvc.Client.SetConnecting();
                    roninsvc.Client.SetConnected();
                    roninsvc.Connect();
                    roninsvc.Client.Start(Il2CppSystem.Net.IPAddress.Parse("18.192.45.68"), 12000, "lalablabla69");


                    roninsvc.FixedUpdate();
                    roninsvc.MarkDirty();
                    roninsvc.Client._receiveList.Clear();
                    roninsvc.Client._receiveBufferSize = -1;
                    //roninsvc.Client._socket._key = "lalablabla69";
                    roninsvc.Client._sendBufferSize = 9999999;
                }
            }
        }
    }
}