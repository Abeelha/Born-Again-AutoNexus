using AutoNexus.Configuration;
using AutoNexus.Constants;
using AutoNexus.Utils;

namespace AutoNexus.Features;

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
        UpdateDisconnectKey();
        UpdateToggleChatKey();
    }

    private void UpdateDisconnectKey()
    {
        string keyString = _config.DisconnectKey.Value.ToUpper();
        if (keyString == "ENTER") keyString = "RETURN";

        try
        {
            _currentDisconnectKey = (KeyCode)Enum.Parse(typeof(KeyCode), keyString, ignoreCase: true);
        }
        catch (ArgumentException)
        {
            _logger.Error($"Invalid KeyCode '{_config.DisconnectKey.Value}' in config. Reverting to default key 'R'.");
            _currentDisconnectKey = KeyCode.R;
            _config.DisconnectKey.Value = ModDefaults.DISCONNECT_KEY;
        }
    }

    private void UpdateToggleChatKey()
    {
        string keyString = ModDefaults.TOGGLE_CHAT_KEY.ToUpper();
        if (keyString == "ENTER") keyString = "RETURN";

        try
        {
            _currentToggleChatKey = (KeyCode)Enum.Parse(typeof(KeyCode), keyString, ignoreCase: true);
        }
        catch (ArgumentException)
        {
            _logger.Error("Invalid ToggleChatKey in defaults. Reverting to default key 'Return'.");
            _currentToggleChatKey = KeyCode.Return;
        }
    }

    private void DisconnectFromWorld()
    {
        try
        {
            var world = UnityEngine.Object.FindObjectOfType<Il2Cpp.World>();
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