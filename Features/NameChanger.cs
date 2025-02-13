using UnityEngine;
using MelonLoader;
using AutoNexus.Configuration;

namespace AutoNexus.Features
{
    public class NameChanger
    {
        private readonly ModConfig _config;
        private readonly MelonLogger.Instance _logger;

        private readonly string _playerObjectName;

        private GameObject _cachedPlayerObject;

        public NameChanger(ModConfig config, MelonLogger.Instance logger, string playerObjectName = "Character(Clone)")
        {
            _config = config;
            _logger = logger;
            _playerObjectName = playerObjectName;
        }

        public void Update()
        {
            GameObject currentPlayerObject = GameObject.Find(_playerObjectName);

            if (currentPlayerObject == null)
                return;

            if (currentPlayerObject != _cachedPlayerObject)
            {
                _cachedPlayerObject = currentPlayerObject;
                ApplyCustomName(currentPlayerObject);
            }
        }
        public void ForceNameUpdate()
        {
            if (_cachedPlayerObject != null)
            {
                ApplyCustomName(_cachedPlayerObject);
            }
            else
            {
                GameObject currentPlayerObject = GameObject.Find(_playerObjectName);
                if (currentPlayerObject != null)
                {
                    ApplyCustomName(currentPlayerObject);
                }
            }
        }

        private void ApplyCustomName(GameObject playerObject)
        {
            var entity = playerObject.GetComponent<Il2Cpp.Entity>();
            if (entity != null)
            {
                string playerName = _config.PlayerName.Value;
                _logger.Msg($"[NameChanger] Setting entity name and GUI name to: {playerName}");

                entity.SetEntityName(playerName);
                entity.SetEntityGuiName(playerName);

                _logger.Msg($"[NameChanger] Player object '{_playerObjectName}' initialized with custom name: {playerName}");
            }
            else
            {
                _logger.Warning($"[NameChanger] Entity component not found on player object: {_playerObjectName}");
            }
        }
    }
}
