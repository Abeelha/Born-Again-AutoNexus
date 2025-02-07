using UnityEngine;
using AutoNexus.Configuration;
using MelonLoader;
using AutoNexus.Constants;
using Il2Cpp;
using System.Collections;

namespace AutoNexus.Features
{
    public class CameraController
    {
        private readonly ModConfig _config;
        private readonly MelonLogger.Instance _logger;
        private readonly RoofRemover _roofRemover;
        private WorldCamera _worldCamera;
        private Camera _mainCamera;
        private KeyCode _currentZoomInKey;
        private KeyCode _currentZoomOutKey;
        private float _lastUsedPixelsPerUnit;
        private bool _hasInitializedZoom;
        private bool _hasCameraSetup;

        public CameraController(ModConfig config, MelonLogger.Instance logger, RoofRemover roofRemover)
        {
            _config = config;
            _logger = logger;
            _roofRemover = roofRemover;
            _lastUsedPixelsPerUnit = ModDefaults.Camera.DEFAULT_PIXELS_PER_UNIT;
            UpdateZoomKeys();
        }

        public void Reset()
        {
            _worldCamera = null;
            _mainCamera = null;
            _hasInitializedZoom = false;
            _hasCameraSetup = false;
        }

        public void Update()
        {
            TryInitializeCamera();
            HandleZoomAdjustments();
        }

        private void TryInitializeCamera()
        {
            if (_worldCamera == null)
            {
                try 
                {
                    _worldCamera = UnityEngine.Object.FindObjectOfType<WorldCamera>();
                }
                catch (System.Exception ex)
                {
                    _logger.Error($"Error finding WorldCamera: {ex.Message}");
                    return;
                }

                if (_worldCamera == null)
                    return;
            }

            if (!_hasInitializedZoom)
            {
                _worldCamera.PixelsPerUnit = _lastUsedPixelsPerUnit;
                _hasInitializedZoom = true;
                _logger.Msg($"Applied saved camera zoom: PixelsPerUnit = {_lastUsedPixelsPerUnit}");
            }

            if (!_hasCameraSetup)
            {
                try 
                {
                    _mainCamera = _worldCamera._camera;
                    if (_mainCamera != null)
                    {
                        _mainCamera.clearFlags = CameraClearFlags.SolidColor;
                        _mainCamera.cullingMask = 1;
                        _hasCameraSetup = true;
                        _logger.Msg("Camera setup completed successfully");
                    }
                }
                catch (System.Exception ex)
                {
                    _logger.Error($"Error setting up camera: {ex.Message}");
                }
            }
        }

        private void HandleZoomAdjustments()
        {
            if (_worldCamera == null)
                return;

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
                    
                    // Force roof removal after zoom change
                    _roofRemover.ForceRoofRemoval();
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