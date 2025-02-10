using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AutoNexus.Configuration;
using AutoNexus.Constants;
using AutoNexus.Helpers;
using AutoNexus.Utils;
using Il2Cpp;

namespace AutoNexus.Features;

public class AutoPot
{
    private const float MIN_UPDATE_INTERVAL = 1f / 165f;
    private const float AUTO_POT_DELAY = 0.5f;
    private const float RAPID_HEALTH_DROP_THRESHOLD = -50f;
    private const float EMERGENCY_HEALTH_RATIO = 0.3f;
    private readonly ModConfig _config;
    private readonly MelonLogger.Instance _logger;
    private readonly SoundManager _soundManager;
    private bool _autoPotEnabled = true;
    private byte _autoPotKey;
    private Character _characterComponent;
    private KeyCode _currentAutoPotToggleKey;
    private bool _gracePeriodActive;
    private bool _isSimulatingKeyPress;
    private HealthMonitorState _monitorState = HealthMonitoringHelper.SharedState;
    private GameObject _playerCharacter;

    public AutoPot(MelonLogger.Instance logger, ModConfig config, SoundManager soundManager)
    {
        _logger = logger;
        _config = config;
        _soundManager = soundManager;
        ParseAutoPotKey();
        UpdateAutoPotToggleKey();
        StartInitialization();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void ParseAutoPotKey()
    {
        var keyString = _config.AutoPotKey.Value.Trim();
        if (keyString.Length == 1)
        {
            var ch = keyString[0];
            if (char.IsDigit(ch))
                keyString = "Alpha" + ch;
            else if (char.IsLetter(ch))
                keyString = char.ToUpper(ch).ToString();
        }

        try
        {
            var keyCode = (KeyCode)Enum.Parse(typeof(KeyCode), keyString, true);
            _autoPotKey = (byte)keyCode;
        }
        catch (Exception ex)
        {
            _logger.Error(
                $"Invalid AutoPotKey '{_config.AutoPotKey.Value}'. Reverting to default '1'. Exception: {ex.Message}");
            _autoPotKey = (byte)KeyCode.Alpha1;
            _config.AutoPotKey.Value = "1";
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void UpdateAutoPotToggleKey()
    {
        var keyString = _config.AutoPotToggleKey.Value.ToUpper();
        if (keyString == "ENTER") keyString = "RETURN";

        try
        {
            _currentAutoPotToggleKey = (KeyCode)Enum.Parse(typeof(KeyCode), keyString, true);
        }
        catch (ArgumentException)
        {
            _logger.Error(
                $"Invalid AutoPotToggleKey '{_config.AutoPotToggleKey.Value}' in config. Reverting to default 'H'.");
            _currentAutoPotToggleKey = KeyCode.H;
            _config.AutoPotToggleKey.Value = "H";
        }
    }

    private void StartInitialization()
    {
        MelonCoroutines.Start(InitializePlayer());
    }

    private IEnumerator InitializePlayer()
    {
        var waitInterval = new WaitForSeconds(ModDefaults.INIT_CHECK_INTERVAL);

        while (true)
        {
            if (TryInitializePlayer())
            {
                _logger.Msg("AutoPot: Player initialized successfully.");
                yield break;
            }

            yield return waitInterval;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private bool TryInitializePlayer()
    {
        _playerCharacter = GameObject.Find(ModDefaults.PLAYER_OBJECT_NAME);
        if (_playerCharacter == null)
            return false;

        _characterComponent = _playerCharacter.GetComponent<Character>();
        if (_characterComponent == null)
        {
            _logger.Warning("AutoPot: Character component not found.");
            return false;
        }

        var currentHealth = _characterComponent.Health;
        _monitorState.LastHealthValue = currentHealth;
        _monitorState.PreviousStableHealth = currentHealth;
        _monitorState.MaxHealth = currentHealth;

        _logger.Msg($"AutoPot: Initial max health set to {_monitorState.MaxHealth}");
        return true;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Update()
    {
        if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) &&
            Input.GetKeyDown(_currentAutoPotToggleKey))
        {
            _autoPotEnabled = !_autoPotEnabled;
            _logger.Msg($"AutoPot toggled {(_autoPotEnabled ? "ON" : "OFF")}.");
            _soundManager.PlayAutoPotToggleSound(_autoPotEnabled);
        }

        if (!_autoPotEnabled)
            return;

        if (!ValidatePlayerState())
            return;

        HealthMonitoringHelper.UpdateStability(_monitorState, _characterComponent.Health, MIN_UPDATE_INTERVAL,
            ModDefaults.HEALTH_STABILITY_TIME, _logger);
        ProcessHealthCheck();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private bool ValidatePlayerState()
    {
        if (_playerCharacter != null && _playerCharacter.activeSelf)
            return !_gracePeriodActive;

        _playerCharacter = GameObject.Find(ModDefaults.PLAYER_OBJECT_NAME);
        if (_playerCharacter == null)
            return false;

        _characterComponent = _playerCharacter.GetComponent<Character>();
        if (_characterComponent != null)
        {
            _logger.Msg("Player reconnected. Starting grace period...");
            StartGracePeriod(ModDefaults.GRACE_PERIOD_DEFAULT);
            return false;
        }

        return false;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void ProcessHealthCheck()
    {
        var currentHealth = _characterComponent.Health;
        var healthRatio = _monitorState.MaxHealth > 0 ? (float)currentHealth / _monitorState.MaxHealth : 1f;

        var shouldPot = false;
        var reason = "";


        if (_monitorState.HealthDropRate < RAPID_HEALTH_DROP_THRESHOLD && healthRatio < EMERGENCY_HEALTH_RATIO)
        {
            shouldPot = true;
            reason = $"rapid health drop ({_monitorState.HealthDropRate:F2}/s)";
        }

        else if (healthRatio <= _config.AutoPotHealthThreshold.Value)
        {
            shouldPot = true;
            reason = "below threshold";
        }

        if (!_gracePeriodActive && shouldPot && !_isSimulatingKeyPress)
        {
            _logger.Msg(
                $"AutoPot: Health is low ({currentHealth}/{_monitorState.MaxHealth} = {healthRatio:P}) - {reason}. Using health potion.");
            MelonCoroutines.Start(SimulateKeyPress());
        }

        if (currentHealth > _monitorState.MaxHealth)
        {
            _monitorState.MaxHealth = currentHealth;
            _logger.Msg($"AutoPot: Max health updated to {_monitorState.MaxHealth}");
        }
    }

    private IEnumerator SimulateKeyPress()
    {
        _isSimulatingKeyPress = true;

        KeyDown(_autoPotKey);
        yield return new WaitForSeconds(0.1f);
        KeyUp(_autoPotKey);

        yield return new WaitForSeconds(AUTO_POT_DELAY);
        _logger.Msg("AutoPot: Health potion key press simulation complete.");
        _isSimulatingKeyPress = false;
    }

    private void StartGracePeriod(float duration)
    {
        _gracePeriodActive = true;
        _logger.Msg($"Grace period: {duration}s");
        MelonCoroutines.Start(GracePeriodCooldown(duration));
    }

    private IEnumerator GracePeriodCooldown(float duration)
    {
        yield return new WaitForSecondsRealtime(duration);
        _gracePeriodActive = false;
        _logger.Msg("Grace period ended.");
    }

    #region keybd_event Interop

    [DllImport("user32.dll", SetLastError = true)]
    private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

    private const uint KEYEVENTF_KEYDOWN = 0x0;
    private const uint KEYEVENTF_KEYUP = 0x2;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void KeyDown(byte vk)
    {
        keybd_event(vk, 0, KEYEVENTF_KEYDOWN, UIntPtr.Zero);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void KeyUp(byte vk)
    {
        keybd_event(vk, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
    }

    #endregion
}