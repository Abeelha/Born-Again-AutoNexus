using MelonLoader;
using AutoNexus.Configuration;
using AutoNexus.Features;
using AutoNexus.UI;
using AutoNexus.Utils;
using ImGuiNET;

namespace AutoNexus
{
    public class AutonexusMod : MelonMod
    {
        private ModUI _ui;
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
            try 
            {
                System.Runtime.InteropServices.NativeLibrary.Load("cimgui");
                if (ImGui.GetCurrentContext() == IntPtr.Zero)
                {
                    IntPtr context = ImGui.CreateContext();
                    ImGui.SetCurrentContext(context);

                    var io = ImGui.GetIO();
                    io.ConfigFlags |= ImGuiConfigFlags.DpiEnableScaleViewports;
                    io.ConfigFlags |= ImGuiConfigFlags.DpiEnableScaleFonts;
                }
                _config = new ModConfig();
                _config.Initialize(LoggerInstance);
        
                _ui = new ModUI(_config, LoggerInstance);
                _soundManager = new SoundManager(LoggerInstance);
                _autoNexus = new Features.AutoNexus(_config, LoggerInstance);
                _cameraController = new CameraController(_config, LoggerInstance);
                _keyboardController = new KeyboardController(_config, LoggerInstance, _soundManager);
                _nameChanger = new NameChanger(_config, LoggerInstance, "Character(Clone)");
                _antiAFK = new AntiAFK(LoggerInstance);
                _autoPot = new AutoPot(LoggerInstance, _config, _soundManager);
            }
            catch (System.Exception ex)
            {
                LoggerInstance.Error($"Failed to initialize: {ex}");
            }
        }

        public override void OnUpdate()
        {
            _nameChanger?.Update();
            _keyboardController?.Update();
            _cameraController?.Update();
            _antiAFK?.Update();
            _autoPot?.Update();
            _autoNexus?.Update();
            _ui?.OnGUI();
        }

        public override void OnApplicationQuit()
        {
            _cameraController?.Reset();
        }
    }
}