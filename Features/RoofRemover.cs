using System.Collections;
using Il2Cpp;
using Il2CppInterop.Runtime;
using Object = UnityEngine.Object;

namespace AutoNexus.Features;

public class RoofRemover
{
    private readonly MelonLogger.Instance _logger;
    private float _checkInterval = 0.5f;
    private bool _isActive;
    private int _lastChunkCount;
    private HashSet<int> _processedChunkIds;

    public RoofRemover(MelonLogger.Instance logger)
    {
        _logger = logger;
        _processedChunkIds = new HashSet<int>();
    }

    public void RemoveRoofs()
    {
        if (!_isActive)
        {
            _isActive = true;
            _processedChunkIds.Clear();
            MelonCoroutines.Start(MonitorForNewChunks());
        }

        DisableAllCeilingChunks(true);
    }

    private IEnumerator MonitorForNewChunks()
    {
        var waitInterval = new WaitForSeconds(_checkInterval);

        while (_isActive)
        {
            DisableAllCeilingChunks(false);
            yield return waitInterval;
        }
    }

    private void DisableAllCeilingChunks(bool forceUpdate)
    {
        try
        {
            var objects = Object.FindObjectsOfType(Il2CppType.Of<TileChunk>());

            if (!forceUpdate && objects.Length == _lastChunkCount)
                return;

            _lastChunkCount = objects.Length;

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

                    var instanceId = chunk.GetInstanceID();
                    if (!forceUpdate && _processedChunkIds.Contains(instanceId))
                        continue;

                    chunk.SetActive(false);

                    if (chunk.MeshRenderer != null)
                    {
                        chunk.MeshRenderer.enabled = false;
                    }

                    if (chunk.Size != null)
                    {
                        var totalTiles = chunk.Size.x * chunk.Size.y;
                        for (var i = 0; i < totalTiles; i++)
                        {
                            chunk.SetAlpha(0f, i);
                        }
                    }

                    _processedChunkIds.Add(instanceId);
                }

                if (_processedChunkIds.Count > 1000)
                {
                    _processedChunkIds.Clear();
                }
            }
        }
        catch (Exception ex)
        {
            _logger.Error($"Error in ceiling removal: {ex.Message}");
        }
    }

    public void OnNewInstance()
    {
        _logger.Msg("New instance detected - Cleaning up old roof removal data");
        CleanupOldData();
        RemoveRoofs();
    }

    private void CleanupOldData()
    {
        _processedChunkIds.Clear();
        _lastChunkCount = 0;
        _isActive = false;
    }

    public void Stop()
    {
        _isActive = false;
        CleanupOldData();
    }

    public void Reset()
    {
        Stop();
        RemoveRoofs();
    }

    public void ForceRoofRemoval()
    {
        DisableAllCeilingChunks(true);
    }
}