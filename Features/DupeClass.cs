using UnityEngine;
using MelonLoader;
using AutoNexus.Configuration;
using System;
using Il2Cpp;
using Il2CppZero.Game.Client;
using System.Collections;
using Il2CppSystem.Runtime.InteropServices;

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


        public void UpdateSpam()
        {
            var roninsvc = UnityEngine.Object.FindObjectOfType<Il2Cpp.RoninGameService>();
            for (int i = 0; i < 500; i++)
            {
                roninsvc.Update();
            }
        }

        public void Update()
        {
            if (Input.GetKeyDown(_toggleKey))
            {
                
                var roninsvc = UnityEngine.Object.FindObjectOfType<Il2Cpp.RoninGameService>();
                var accMenu = UnityEngine.Object.FindObjectOfType<Il2Cpp.AccountMenu>();
                var aimClass = UnityEngine.Object.FindObjectOfType<Il2Cpp.Aimer>();
                var slotMenuClass = UnityEngine.Object.FindObjectOfType<Il2Cpp.CharacterSlotMenu>();
                var bankMenuClass = UnityEngine.Object.FindObjectOfType<Il2Cpp.BankMenu>();
                var bankRowClass = UnityEngine.Object.FindObjectOfType<Il2Cpp.BankRow>();
                var tradeMenuClass = UnityEngine.Object.FindObjectOfType<Il2Cpp.TradeMenu>();
                var travelMinimapClass = UnityEngine.Object.FindObjectOfType<Il2Cpp.TravelMinimap>();
                var requestClass = UnityEngine.Object.FindObjectOfType<Il2Cpp.Request>();
                var projectileClass = UnityEngine.Object.FindObjectOfType<Il2Cpp.Projectile>();
                var attackManagerClass = UnityEngine.Object.FindObjectOfType<Il2Cpp.PlayerAttackManager>();
                var orbSoulClass = UnityEngine.Object.FindObjectOfType<Il2Cpp.OrbSoul>();
                var moveClass = UnityEngine.Object.FindObjectOfType<Il2Cpp.MoveGizmo>();
                var medallionShopClass = UnityEngine.Object.FindObjectOfType<Il2Cpp.MedallionShop>();
                var medallionClass = UnityEngine.Object.FindObjectOfType<Il2Cpp.Medallions>();
                var honorClass = UnityEngine.Object.FindObjectOfType<Il2Cpp.Honor>();
                var shopClass = UnityEngine.Object.FindObjectOfType<Il2Cpp.Shop>();
                var playerMoveManagerClass = UnityEngine.Object.FindObjectOfType<Il2Cpp.PlayerMovementManager>();
                var pickupSlotContainerClass = UnityEngine.Object.FindObjectOfType<Il2Cpp.PickupSlotContainer>();


                /*for (int i = 0; i < 50000; i++)
                {

                    tradeMenuClass.Accept();

                    //tradeMenuClass.Accept();

                    //requestClass.Ok();

                    //projectileClass.Expire();


                    pickupSlotContainerClass.MarkDirty();
                    pickupSlotContainerClass.LateUpdate();



                    #region Attack Manager

                    //attackManagerClass.NetworkInputUpdate();
                    //attackManagerClass.NetworkLateUpdate();
                    //attackManagerClass.enabled = false;

                    #endregion

                    #region Orb Class

                    //orbSoulClass.Duration = 1000;
                    //orbSoulClass._t = 99999;
                    //orbSoulClass.MarkDirty();

                    #endregion

                    #region Honor Class

                    //honorClass._currency = 999999;

                    #endregion

                    #region Shop Class

                    //Vector2 newPosition = new Vector2(99, 99);
                    //shopClass.SetPosition(newPosition);

                    #endregion

                    #region Medallion Shop Class

                    //medallionClass._currency = 9999999;
                    //medallionShopClass.SetPriceString("1");
                    //medallionShopClass.Amount = 10;
                    //medallionShopClass.Purchase();

                    #endregion



                    #region Bank Menu Class
                    //bankMenuClass.Start();
                    //bankMenuClass.Enter();
                    //bankMenuClass.Show();
                    //bankMenuClass.UpdateOnSubmit();

                    //bankMenuClass.CreateRow();
                    //_logger.Msg($"[CreateRow] Created Bank Row: {i.ToString()}");

                    //bankMenuClass.Update();
                    //bankMenuClass.LateUpdate();

                    //bankMenuClass.PurchaseHonor();
                    //_logger.Msg($"[PurcahseHonor] Bought Bank Row for Honor: {i.ToString()}");

                    //bankMenuClass.LoadBank();
                    //bankMenuClass.Update();
                    //bankMenuClass.StopAllCoroutines();
                    //bankMenuClass.LateUpdate();
                    //bankMenuClass.UpdateOnSubmit();
                    //bankMenuClass.UpdateShouldClose();
                    //bankMenuClass.UpdateTrackedTasks();
                    //bankMenuClass.UpdateVisibility();
                    //_logger.Msg($"[BankMenuClass] Ran it: {i.ToString()}");
                    #endregion

                    //slotMenuClass.Update();


                    #region Roninservice
                    //roninsvc.FixedUpdate(); // Teleport
                    //roninsvc.Client._dataToSend = null;
                    //roninsvc.CancelInvoke();
                    //roninsvc.EnsureRunningOnMainThread();
                    //roninsvc.Client.SendData(uint.MaxValue);
                    //roninsvc._Client_k__BackingField.SendData(19);
                    //roninsvc.Client._eventTime = 0;
                    //roninsvc.Client._transferTime = 0;
                    //roninsvc._Client_k__BackingField.SetConnected();
                    //roninsvc.Client.UpdateState();
                    //roninsvc.CancelInvoke();
                    //roninsvc._Client_k__BackingField.Start(Il2CppSystem.Net.IPAddress.Parse("18.192.45.68"), 12000, "lala");
                    #endregion

                }*/
            }
        }
    }
}