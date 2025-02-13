// KeyboardController.cs
using UnityEngine;
using AutoNexus.Configuration;
using MelonLoader;
using AutoNexus.Utils;
using AutoNexus.Helpers;
using AutoNexus.Constants;

namespace AutoNexus.Features
{
    public class KeyboardController
    {
        private readonly ModConfig _config;
        private readonly MelonLogger.Instance _logger;
        private KeyCode _currentDisconnectKey;
        private KeyCode _currentToggleChatKey;
        private bool _isChatMode;
        private bool _isDisconnectEnabled = true;
        private readonly SoundManager _soundManager;


        public KeyboardController(ModConfig config, MelonLogger.Instance logger, SoundManager soundManager)
        {
            _config = config;
            _logger = logger;
            _soundManager = soundManager;
            UpdateKeys();
        }

        public void Update()
        {
            HandleDisconnectKey();
            HandleToggleChatKey();
            HandleLockKey();
        }

        private void HandleDisconnectKey()
        {
            if (!_isChatMode && _isDisconnectEnabled && Input.GetKeyDown(_currentDisconnectKey))
            {
                _logger.Msg($"Disconnect key '{_currentDisconnectKey}' pressed. Initiating disconnect...");
                DisconnectFromWorld();
            }
        }

        private void HandleToggleChatKey()
        {
            if (Input.GetKeyDown(_currentToggleChatKey))
            {
                _isChatMode = !_isChatMode;
                _logger.Msg($"Chat mode {(_isChatMode ? "enabled" : "disabled")}. Disconnect functionality is now {(!_isChatMode ? "active" : "inactive")}.");
            }
        }

        private void HandleLockKey()
        {
            if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) && Input.GetKeyDown(_currentDisconnectKey))
            {
                _isDisconnectEnabled = !_isDisconnectEnabled;
                _logger.Msg($"Disconnect functionality is now {(_isDisconnectEnabled ? "enabled" : "disabled")}.");
                _soundManager.PlayAutoNexusToggleSound(_isDisconnectEnabled);
            }
        }

        private void UpdateKeys()
        {
            _currentDisconnectKey = KeyInputHelper.ParseKeyInput(_config.DisconnectKey.Value);
            _currentToggleChatKey = KeyInputHelper.ParseKeyInput(ModDefaults.TOGGLE_CHAT_KEY);
        }

        private void DisconnectFromWorld()
        {
            var world = UnityEngine.Object.FindObjectOfType<Il2Cpp.World>();
            if (world != null)
            {
                world.Disconnect();
                _logger.Msg("Disconnected successfully.");
            }
        }
    }
}