/*
using HarmonyLib;
using UnityEngine;
using MelonLoader;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace AutoNexus.Features
{
    public class EnemySeeAll
    {
        private readonly MelonLogger.Instance _logger;
        private const string TARGET_LAYER = "Unculled"; // Create a layer named "Unculled" in Unity

        public EnemySeeAll(MelonLogger.Instance logger)
        {
            _logger = logger;
            _logger.Msg("Enemy visibility override enabled");
        }

        public void Update()
        {
            ForceEnemiesVisible();
            AdjustCameraCulling();
        }

        private void ForceEnemiesVisible()
        {
            // Find all enemies by component (more reliable than name)
            var enemies = GameObject.FindObjectsOfType<GameObject>()
                .Where(obj => obj.GetComponent<il2cpp.Enemy>() != null);

            foreach (var enemy in enemies)
            {
                if (enemy == null) continue;

                // Force active
                if (!enemy.activeSelf) enemy.SetActive(true);

                // Enable SpriteRenderer
                var renderer = enemy.GetComponent<SpriteRenderer>();
                if (renderer != null)
                {
                    renderer.enabled = true;
                    // Set layer to "Unculled" to bypass culling
                    enemy.layer = LayerMask.NameToLayer(TARGET_LAYER);
                }

                // Optional: Disable other components that might hide the enemy
                var enemyScript = enemy.GetComponent<il2cpp.Enemy>();
                if (enemyScript != null)
                {
                    // Example: Disable distance-based hiding logic
                    enemyScript.enabled = false; // Caution: Might break gameplay
                }
            }
        }

        private void AdjustCameraCulling()
        {
            // Adjust all cameras to include the "Unculled" layer
            var cameras = GameObject.FindObjectsOfType<Camera>();
            foreach (var cam in cameras)
            {
                if (cam == null) continue;
                cam.cullingMask |= (1 << LayerMask.NameToLayer(TARGET_LAYER));
                cam.farClipPlane = 10000f; // Extend render distance
            }
        }
    }

    [HarmonyPatch(typeof(Renderer))]
    [HarmonyPatch("isVisible", MethodType.Getter)]
    class RendererVisibilityPatch
    {
        static bool Prefix(Renderer __instance, ref bool __result)
        {
            // Force isVisible to true for all enemies
            if (__instance.GetComponent<il2cpp.Enemy>() != null)
            {
                __result = true;
                return false; // Skip original method
            }
            return true;
        }
    }
}*/