using AutoNexus.Configuration;
using AutoNexus.Constants;
using AutoNexus.Helpers;
using AutoNexus.Utils;
using Il2Cpp;
using MelonLoader;
using UnityEngine;
using Object = UnityEngine.Object;

namespace AutoNexus.Features
{
    public class KeyboardController
    {
        private readonly ModConfig _config;
        private readonly MelonLogger.Instance _logger;
        private readonly SoundManager _soundManager;
        private KeyCode _currentDisconnectKey;
        private KeyCode _currentToggleChatKey;
        private bool _isChatMode;
        private bool _isDisconnectEnabled = true;

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
            UpdateDisconnectKey();

            if (!_isChatMode && _isDisconnectEnabled && Input.GetKeyDown(_currentDisconnectKey) &&
                !Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.RightControl))
            {
                _logger.Msg($"Disconnect key '{_currentDisconnectKey}' pressed. Initiating disconnect...");
                DisconnectFromWorld();
            }
        }

        private void HandleToggleChatKey()
        {
            UpdateToggleChatKey();

            if (Input.GetKeyDown(_currentToggleChatKey))
            {
                _isChatMode = !_isChatMode;
                _logger.Msg(
                    $"Chat mode {(_isChatMode ? "enabled" : "disabled")}. Disconnect functionality is now {(!_isChatMode ? "active" : "inactive")}.");
            }
        }

        private void HandleLockKey()
        {
            if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) &&
                Input.GetKeyDown(_currentDisconnectKey))
            {
                _isDisconnectEnabled = !_isDisconnectEnabled;
                _logger.Msg($"Disconnect functionality is now {(_isDisconnectEnabled ? "enabled" : "disabled")}.");
                _soundManager.PlayAutoNexusToggleSound(_isDisconnectEnabled);
            }
        }

        private void UpdateKeys()
        {
            UpdateDisconnectKey();
            UpdateToggleChatKey();
        }

        private void UpdateDisconnectKey()
        {
            try
            {
                _currentDisconnectKey = KeyInputHelper.ParseKeyInput(_config.DisconnectKey.Value);
            }
            catch (Exception ex)
            {
                _logger.Error(
                    $"Invalid KeyCode '{_config.DisconnectKey.Value}' in config. Reverting to default key 'F'. Exception: {ex.Message}");
                _currentDisconnectKey = KeyCode.F;
                _config.DisconnectKey.Value = ModDefaults.DISCONNECT_KEY;
            }
        }

        private void UpdateToggleChatKey()
        {
            try
            {
                _currentToggleChatKey = KeyInputHelper.ParseKeyInput(ModDefaults.TOGGLE_CHAT_KEY);
            }
            catch (Exception ex)
            {
                _logger.Error(
                    $"Invalid ToggleChatKey in defaults. Reverting to default key 'Return'. Exception: {ex.Message}");
                _currentToggleChatKey = KeyCode.Return;
            }
        }

        private void DisconnectFromWorld()
        {
            try
            {
                var world = Object.FindObjectOfType<World>();
                if (world == null)
                {
                    _logger.Warning("World object not found.");
                    return;
                }

                _logger.Msg("Disconnecting from world...");
                world.Disconnect();
                _logger.Msg("Disconnected successfully.");
            }
            catch (Exception ex)
            {
                _logger.Error($"Disconnect error: {ex.Message}");
            }
        }
    }
}