using UnityEngine;
using MelonLoader;
using Il2Cpp;
using System.Collections;
using System.Linq;

namespace AutoNexus.Features
{
    public class RoofRemover
    {
        private readonly MelonLogger.Instance _logger;
        private bool _hasInitializedInteriorVisibility;
        private int _initializationAttempts;

        public RoofRemover(MelonLogger.Instance logger)
        {
            _logger = logger;
            _initializationAttempts = 0;
            MelonCoroutines.Start(InitializeInteriorVisibility());
        }

        public void Reset()
        {
            _hasInitializedInteriorVisibility = false;
            _initializationAttempts = 0;
            MelonCoroutines.Start(InitializeInteriorVisibility());
        }

        public void ForceRoofRemoval()
        {
            _hasInitializedInteriorVisibility = false;
            _initializationAttempts = 0;
            MelonCoroutines.Start(InitializeInteriorVisibility());
        }

        private IEnumerator InitializeInteriorVisibility()
        {
            while (!_hasInitializedInteriorVisibility)
            {
                _initializationAttempts++;

                // Limit logging and attempts
                if (_initializationAttempts > 10)
                {
                    _logger.Msg("Max initialization attempts reached. Stopping roof removal attempts.");
                    yield break;
                }

                try 
                {
                    var allGameObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

                    if (allGameObjects != null && allGameObjects.Length > 0)
                    {
                        bool roofRemoved = false;
                        foreach (var go in allGameObjects)
                        {
                            if (go == null) continue;

                            var renderers = go.GetComponents<Renderer>();
                            foreach (var renderer in renderers)
                            {
                                if (renderer == null) continue;

                                renderer.allowOcclusionWhenDynamic = false;
                                renderer.receiveShadows = false;
                                renderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;

                                string rendererName = renderer.gameObject.name.ToLower();
                                if (rendererName.Contains("roof") || rendererName.Contains("ceiling"))
                                {
                                    renderer.enabled = false;
                                    roofRemoved = true;
                                }
                            }
                        }

                        if (roofRemoved)
                        {
                            _logger.Msg("Roof removal applied successfully!");
                            _hasInitializedInteriorVisibility = true;
                            yield break;
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    _logger.Error($"Error in roof removal: {ex.Message}");
                }

                yield return new WaitForSeconds(7f);
            }
        }
    }
}