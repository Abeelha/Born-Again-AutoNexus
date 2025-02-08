using UnityEngine;
using MelonLoader;
using Il2Cpp;
using System.Collections;
using System.Linq;
using Il2CppInterop.Runtime;

namespace AutoNexus.Features
{
    public class RoofRemover
    {
        private readonly MelonLogger.Instance _logger;
        private bool _isActive = false;
        private float _checkInterval = 0.1f;
        private Coroutine _monitorCoroutine;

        public RoofRemover(MelonLogger.Instance logger)
        {
            _logger = logger;
        }

        public void RemoveRoofs()
        {
            if (!_isActive)
            {
                _isActive = true;
                MelonCoroutines.Start(MonitorForNewChunks());
                _logger.Msg("Started continuous ceiling removal monitoring");
            }

            DisableAllCeilingChunks();
        }

        private IEnumerator MonitorForNewChunks()
        {
            while (_isActive)
            {
                DisableAllCeilingChunks();
                yield return new WaitForSeconds(_checkInterval);
            }
        }

        private void DisableAllCeilingChunks()
        {
            try 
            {
                var objects = UnityEngine.Object.FindObjectsOfType(Il2CppType.Of<TileChunk>());
                var ceilingChunks = objects?.Select(obj => obj.TryCast<TileChunk>())
                                         .Where(chunk => chunk != null && 
                                                       chunk.name.Contains("CeilingChunk"))
                                         .ToArray();

                if (ceilingChunks != null && ceilingChunks.Length > 0)
                {
                    foreach (var chunk in ceilingChunks)
                    {
                        if (chunk == null) 
                            continue;

                        // Disable the chunk itself
                        chunk.SetActive(false);

                        // Disable rendering
                        if (chunk.MeshRenderer != null)
                        {
                            chunk.MeshRenderer.enabled = false;
                        }

                        // Set alpha to 0 for all tiles
                        if (chunk.Size != null)
                        {
                            int totalTiles = chunk.Size.x * chunk.Size.y;
                            for (int i = 0; i < totalTiles; i++)
                            {
                                chunk.SetAlpha(0f, i);
                            }
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                _logger.Error($"Error in ceiling removal: {ex.Message}\n{ex.StackTrace}");
            }
        }

        public void Stop()
        {
            _isActive = false;
        }

        public void Reset()
        {
            Stop();
            RemoveRoofs();
        }

        public void ForceRoofRemoval()
        {
            DisableAllCeilingChunks();
        }
    }
}