using UnityEngine;
using AutoNexus.Configuration;
using MelonLoader;
using AutoNexus.Constants;
using Il2Cpp;

namespace AutoNexus.Features
{
    public class CameraController
    {
        private readonly ModConfig _config;
        private readonly MelonLogger.Instance _logger;
        private WorldCamera _worldCamera;
        private KeyCode _currentZoomInKey;
        private KeyCode _currentZoomOutKey;
        private float _lastUsedPixelsPerUnit;
        private bool _hasInitializedZoom;

        public CameraController(ModConfig config, MelonLogger.Instance logger)
        {
            _config = config;
            _logger = logger;
            _lastUsedPixelsPerUnit = ModDefaults.Camera.DEFAULT_PIXELS_PER_UNIT;
            UpdateZoomKeys();
        }

        public void Reset()
        {
            _worldCamera = null;
        }

        public void Update()
        {
            if (!TryInitializeCamera())
                return;

            HandleZoomAdjustments();
        }

        private bool TryInitializeCamera()
        {
            if (_worldCamera == null)
            {
                _worldCamera = UnityEngine.Object.FindObjectOfType<WorldCamera>();
                if (_worldCamera == null)
                    return false;

                if (!_hasInitializedZoom)
                {
                    _worldCamera.PixelsPerUnit = _lastUsedPixelsPerUnit;
                    _hasInitializedZoom = true;
                    _logger.Msg($"Applied saved camera zoom: PixelsPerUnit = {_lastUsedPixelsPerUnit}");
                }
            }
            return true;
        }

        private void HandleZoomAdjustments()
        {
            float newPixelsPerUnit = _worldCamera.PixelsPerUnit;
            bool adjustmentMade = false;

            float scrollDelta = Input.mouseScrollDelta.y;
            if (scrollDelta != 0)
            {
                if ((scrollDelta > 0 && _config.ZoomInKey.Value.ToUpper() == "MOUSESCROLLUP") ||
                    (scrollDelta < 0 && _config.ZoomOutKey.Value.ToUpper() == "MOUSESCROLLDOWN"))
                {
                    newPixelsPerUnit += ModDefaults.Camera.PIXELS_PER_UNIT_STEP * Mathf.Sign(scrollDelta);
                    adjustmentMade = true;
                }
            }

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

            if (adjustmentMade)
            {
                newPixelsPerUnit = Mathf.Clamp(newPixelsPerUnit, ModDefaults.Camera.MIN_PIXELS_PER_UNIT, ModDefaults.Camera.MAX_PIXELS_PER_UNIT);
                if (System.Math.Abs(newPixelsPerUnit - _worldCamera.PixelsPerUnit) > 0.01f)
                {
                    _worldCamera.PixelsPerUnit = newPixelsPerUnit;
                    _lastUsedPixelsPerUnit = newPixelsPerUnit;
                    _logger.Msg($"Camera Zoom Updated: PixelsPerUnit = {newPixelsPerUnit}");
                }
            }
        }

        private void UpdateZoomKeys()
        {
            try
            {
                string zoomInString = _config.ZoomInKey.Value.ToUpper();
                if (zoomInString == "MOUSESCROLLUP")
                {
                    _currentZoomInKey = KeyCode.None;
                }
                else
                {
                    _currentZoomInKey = (KeyCode)System.Enum.Parse(typeof(KeyCode), zoomInString, ignoreCase: true);
                }

                string zoomOutString = _config.ZoomOutKey.Value.ToUpper();
                if (zoomOutString == "MOUSESCROLLDOWN")
                {
                    _currentZoomOutKey = KeyCode.None;
                }
                else
                {
                    _currentZoomOutKey = (KeyCode)System.Enum.Parse(typeof(KeyCode), zoomOutString, ignoreCase: true);
                }
            }
            catch (System.ArgumentException ex)
            {
                _logger.Error($"Invalid zoom KeyCode in config: {ex.Message}. Reverting to defaults.");
                _currentZoomInKey = KeyCode.None;
                _currentZoomOutKey = KeyCode.None;
                _config.ZoomInKey.Value = ModDefaults.Camera.DEFAULT_ZOOM_IN_KEY;
                _config.ZoomOutKey.Value = ModDefaults.Camera.DEFAULT_ZOOM_OUT_KEY;
            }
        }
    }
}