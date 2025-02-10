using System.Collections;
using System.Runtime.CompilerServices;
using AutoNexus.Configuration;
using AutoNexus.Constants;
using AutoNexus.Helpers;
using Il2Cpp;
using Object = UnityEngine.Object;

namespace AutoNexus.Features;

public class AutoNexus
{
    private const int MAX_WAITING_LOGS = 3;
    private const float MIN_UPDATE_INTERVAL = 1f / 165f;
    private readonly ModConfig _config;
    private readonly MelonLogger.Instance _logger;
    private readonly HealthMonitorState _monitorState = HealthMonitoringHelper.SharedState;
    private float _accumulatedTime;
    private Character _characterComponent;

    private bool _gracePeriodActive;
    private bool _isMonitoringActive;

    private float _lastUpdateTime;
    private object _monitoringCoroutine;
    private GameObject _playerCharacter;
    private int _waitingLogCounter;

    public AutoNexus(ModConfig config, MelonLogger.Instance logger)
    {
        _config = config;
        _logger = logger;
        _lastUpdateTime = Time.realtimeSinceStartup;
        StartInitialization();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
                StartHealthMonitoring();
                yield break;
            }

            if (_waitingLogCounter < MAX_WAITING_LOGS)
            {
                _logger.Msg("Waiting for player character...");
                _waitingLogCounter++;
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
            _logger.Warning("Character component not found.");
            return false;
        }

        InitializeHealthState();
        InitializeEntityName();
        return true;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void InitializeHealthState()
    {
        var currentHealth = _characterComponent.Health;
        _monitorState.LastHealthValue = currentHealth;
        _monitorState.PreviousStableHealth = currentHealth;
        _monitorState.MaxHealth = currentHealth;
    }

    private void InitializeEntityName()
    {
        var entity = _playerCharacter.GetComponent<Entity>();
        if (entity != null)
        {
            _logger.Msg($"Setting entity name and GUI name to: {_config.PlayerName.Value}");
            entity.SetEntityName(_config.PlayerName.Value);
            entity.SetEntityGuiName(_config.PlayerName.Value);
        }
        else
        {
            _logger.Warning("Entity component not found on player character during initialization.");
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Update()
    {
        if (!_isMonitoringActive || _characterComponent == null)
            return;

        var currentTime = Time.realtimeSinceStartup;
        var deltaTime = currentTime - _lastUpdateTime;
        _lastUpdateTime = currentTime;

        _accumulatedTime += deltaTime;

        if (_accumulatedTime >= MIN_UPDATE_INTERVAL)
        {
            if (!ValidatePlayerState())
                return;

            try
            {
                ProcessHealthCheck();
                HealthMonitoringHelper.UpdateStability(_monitorState, _characterComponent.Health, deltaTime,
                    ModDefaults.HEALTH_STABILITY_TIME, _logger);
            }
            catch (Exception ex)
            {
                _logger.Error($"Health monitoring error: {ex.Message}");
                StopHealthMonitoring();
            }

            _accumulatedTime = 0f;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void StartHealthMonitoring()
    {
        if (_isMonitoringActive)
            return;

        _isMonitoringActive = true;
        _logger.Msg("Starting health monitoring...");
        _monitoringCoroutine = MelonCoroutines.Start(MonitorPlayerHealth());
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void StopHealthMonitoring()
    {
        if (!_isMonitoringActive)
            return;

        _isMonitoringActive = false;
        if (_monitoringCoroutine != null)
        {
            MelonCoroutines.Stop(_monitoringCoroutine);
            _monitoringCoroutine = null;
        }
    }

    private IEnumerator MonitorPlayerHealth()
    {
        var waitInterval = new WaitForSeconds(MIN_UPDATE_INTERVAL);
        var lastLoggedHealth = -1;

        while (_isMonitoringActive)
        {
            if (!ValidatePlayerState())
            {
                yield return waitInterval;
                continue;
            }

            try
            {
                ProcessHealthCheck(ref lastLoggedHealth);
            }
            catch (Exception ex)
            {
                _logger.Error($"Health monitoring error: {ex.Message}");
                StopHealthMonitoring();
            }

            yield return waitInterval;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private bool ValidatePlayerState()
    {
        if (_playerCharacter != null && _playerCharacter.activeSelf)
            return true;

        _playerCharacter = GameObject.Find(ModDefaults.PLAYER_OBJECT_NAME);
        if (_playerCharacter == null)
            return false;

        _characterComponent = _playerCharacter.GetComponent<Character>();
        if (_characterComponent != null)
        {
            _logger.Msg("Player reconnected. Starting grace period...");
            StartGracePeriod(ModDefaults.GRACE_PERIOD_DEFAULT);
            return true;
        }

        return false;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void ProcessHealthCheck()
    {
        var currentHealth = _characterComponent.Health;
        HealthMonitoringHelper.CheckCriticalHealth(currentHealth, _monitorState.MaxHealth,
            _config.HealthThreshold.Value, _logger);

        if (HealthMonitoringHelper.ShouldTriggerNexus(_config.HealthThreshold.Value, _gracePeriodActive))
        {
            DisconnectFromWorld();
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void ProcessHealthCheck(ref int lastLoggedHealth)
    {
        var currentHealth = _characterComponent.Health;

        if (currentHealth != lastLoggedHealth)
        {
            lastLoggedHealth = currentHealth;
            HealthMonitoringHelper.CheckCriticalHealth(currentHealth, _monitorState.MaxHealth,
                _config.HealthThreshold.Value, _logger);
        }

        if (HealthMonitoringHelper.ShouldTriggerNexus(_config.HealthThreshold.Value, _gracePeriodActive))
        {
            DisconnectFromWorld();
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
}