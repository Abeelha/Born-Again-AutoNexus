using AutoNexus.Configuration;
using AutoNexus.Constants;
using Il2Cpp;
using Object = UnityEngine.Object;

namespace AutoNexus.Features;

public class CameraController
{
    private const float ZOOM_CHECK_THRESHOLD = 0.1f;
    private const float CHECK_INTERVAL = 0.2f;
    private readonly ModConfig _config;
    private readonly MelonLogger.Instance _logger;
    private readonly RoofRemover _roofRemover;
    private KeyCode _currentZoomInKey;
    private KeyCode _currentZoomOutKey;
    private bool _hasInitializedZoom;
    private float _lastRemovalCheckZoom;
    private float _lastUsedPixelsPerUnit;
    private Camera _mainCamera;
    private WorldCamera _worldCamera;
    private float _zoomUpdateTimer;

    public CameraController(ModConfig config, MelonLogger.Instance logger, RoofRemover roofRemover)
    {
        _config = config;
        _logger = logger;
        _roofRemover = roofRemover;
        _lastUsedPixelsPerUnit = ModDefaults.Camera.DEFAULT_PIXELS_PER_UNIT;
        _lastRemovalCheckZoom = _lastUsedPixelsPerUnit;
        UpdateZoomKeys();
    }

    public void Reset()
    {
        _worldCamera = null;
        _mainCamera = null;
        _hasInitializedZoom = false;
        _lastRemovalCheckZoom = ModDefaults.Camera.DEFAULT_PIXELS_PER_UNIT;
        _zoomUpdateTimer = 0f;
    }

    public void Update()
    {
        if (_worldCamera == null)
        {
            TryInitializeCamera();
            return;
        }

        if (!IsValidCamera())
        {
            Reset();
            return;
        }

        HandleZoomAdjustments();

        _zoomUpdateTimer += Time.deltaTime;
        if (_zoomUpdateTimer >= CHECK_INTERVAL)
        {
            CheckForZoomBasedRemoval();
            _zoomUpdateTimer = 0f;
        }
    }

    private bool IsValidCamera()
    {
        try
        {
            var test = _worldCamera.PixelsPerUnit;
            return true;
        }
        catch
        {
            return false;
        }
    }

    private void CheckForZoomBasedRemoval()
    {
        if (_worldCamera == null) return;

        var currentZoom = _worldCamera.PixelsPerUnit;
        if (Mathf.Abs(currentZoom - _lastRemovalCheckZoom) >= ZOOM_CHECK_THRESHOLD)
        {
            _roofRemover.ForceRoofRemoval();
            _lastRemovalCheckZoom = currentZoom;
        }
    }

    private void TryInitializeCamera()
    {
        try
        {
            _worldCamera = Object.FindObjectOfType<WorldCamera>();

            if (_worldCamera != null && !_hasInitializedZoom)
            {
                _worldCamera.PixelsPerUnit = _lastUsedPixelsPerUnit;
                _hasInitializedZoom = true;
                _logger.Msg($"Camera initialized - PixelsPerUnit = {_lastUsedPixelsPerUnit}");
                _roofRemover.OnNewInstance();
            }
        }
        catch (Exception ex)
        {
            _logger.Error($"Error initializing camera: {ex.Message}");
        }
    }

    private void HandleZoomAdjustments()
    {
        var newPixelsPerUnit = _worldCamera.PixelsPerUnit;
        var adjustmentMade = false;

        var scrollDelta = Input.mouseScrollDelta.y;
        if (scrollDelta != 0)
        {
            if ((scrollDelta > 0 && _config.ZoomInKey.Value.ToUpper() == "MOUSESCROLLUP") ||
                (scrollDelta < 0 && _config.ZoomOutKey.Value.ToUpper() == "MOUSESCROLLDOWN"))
            {
                newPixelsPerUnit += ModDefaults.Camera.PIXELS_PER_UNIT_STEP * Mathf.Sign(scrollDelta);
                adjustmentMade = true;
            }
        }

        if (!adjustmentMade)
        {
            if (_currentZoomInKey != KeyCode.None && Input.GetKeyDown(_currentZoomInKey))
            {
                newPixelsPerUnit += ModDefaults.Camera.PIXELS_PER_UNIT_STEP;
                adjustmentMade = true;
            }
            else if (_currentZoomOutKey != KeyCode.None && Input.GetKeyDown(_currentZoomOutKey))
            {
                newPixelsPerUnit -= ModDefaults.Camera.PIXELS_PER_UNIT_STEP;
                adjustmentMade = true;
            }
        }

        if (adjustmentMade)
        {
            newPixelsPerUnit = Mathf.Clamp(newPixelsPerUnit,
                ModDefaults.Camera.MIN_PIXELS_PER_UNIT,
                ModDefaults.Camera.MAX_PIXELS_PER_UNIT);

            if (Math.Abs(newPixelsPerUnit - _worldCamera.PixelsPerUnit) > 0.01f)
            {
                _worldCamera.PixelsPerUnit = newPixelsPerUnit;
                _lastUsedPixelsPerUnit = newPixelsPerUnit;
                _roofRemover.ForceRoofRemoval();
            }
        }
    }

    private void UpdateZoomKeys()
    {
        try
        {
            _currentZoomInKey = _config.ZoomInKey.Value.ToUpper() == "MOUSESCROLLUP"
                ? KeyCode.None
                : (KeyCode)Enum.Parse(typeof(KeyCode), _config.ZoomInKey.Value, true);

            _currentZoomOutKey = _config.ZoomOutKey.Value.ToUpper() == "MOUSESCROLLDOWN"
                ? KeyCode.None
                : (KeyCode)Enum.Parse(typeof(KeyCode), _config.ZoomOutKey.Value, true);
        }
        catch (ArgumentException ex)
        {
            _logger.Error($"Invalid zoom KeyCode in config: {ex.Message}. Reverting to defaults.");
            _currentZoomInKey = KeyCode.None;
            _currentZoomOutKey = KeyCode.None;
            _config.ZoomInKey.Value = ModDefaults.Camera.DEFAULT_ZOOM_IN_KEY;
            _config.ZoomOutKey.Value = ModDefaults.Camera.DEFAULT_ZOOM_OUT_KEY;
        }
    }
}