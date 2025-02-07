using UnityEngine;
using MelonLoader;
using AutoNexus.Configuration;
using Il2Cpp;
using System.Collections;

namespace AutoNexus.Features
{
    public class RoofRemover
    {
        private readonly MelonLogger.Instance _logger;
        private bool _hasInitializedInteriorVisibility;

        public RoofRemover(MelonLogger.Instance logger)
        {
            _logger = logger;
            MelonCoroutines.Start(InitializeInteriorVisibility());
        }

        public void Reset()
        {
            _hasInitializedInteriorVisibility = false;
            MelonCoroutines.Start(InitializeInteriorVisibility());
        }

        private IEnumerator InitializeInteriorVisibility()
        {
            while (!_hasInitializedInteriorVisibility)
            {
                try 
                {
                    var renderers = UnityEngine.Object.FindObjectsOfType<Renderer>();
                    if (renderers != null)
                    {
                        foreach (var renderer in renderers)
                        {
                            if (renderer != null)
                            {
                                renderer.allowOcclusionWhenDynamic = false;
                                renderer.receiveShadows = false;
                                renderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;

                                if (renderer.gameObject.name.ToLower().Contains("roof") || 
                                    renderer.gameObject.name.ToLower().Contains("ceiling"))
                                {
                                    renderer.enabled = false;
                                }
                            }
                        }
                    }

                    var occlusionAreas = UnityEngine.Object.FindObjectsOfType<OcclusionArea>();
                    if (occlusionAreas != null)
                    {
                        foreach (var area in occlusionAreas)
                        {
                            if (area != null)
                            {
                                area.size = Vector3.zero;
                                area.center = new Vector3(0, -999999, 0);
                            }
                        }
                    }

                    _hasInitializedInteriorVisibility = true;
                    _logger.Msg("Interior visibility initialization completed");
                }
                catch (System.Exception ex)
                {
                    _logger.Error($"Error in interior visibility initialization: {ex.Message}");
                }

                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}