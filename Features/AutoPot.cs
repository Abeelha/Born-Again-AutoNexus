using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using MelonLoader;
using Il2Cpp;
using AutoNexus.Configuration;
using AutoNexus.Constants;

namespace AutoNexus.Features
{
    public class AutoPot
    {
        private readonly MelonLogger.Instance _logger;
        private readonly ModConfig _config;
        private GameObject _playerCharacter;
        private Character _characterComponent;
        private int _maxHealth = -1;
        private bool _hasUsedAutoPot;
        private bool _isSimulatingKeyPress;

        public AutoPot(MelonLogger.Instance logger, ModConfig config)
        {
            _logger = logger;
            _config = config;
            StartInitialization();
        }

        private void StartInitialization()
        {
            MelonCoroutines.Start(InitializePlayer());
        }

        private IEnumerator InitializePlayer()
        {
            var waitInterval = new WaitForSeconds(_config.InitCheckInterval.Value);

            while (true)
            {
                if (TryInitializePlayer())
                {
                    _logger.Msg("AutoPot: Player initialized successfully.");
                    yield break;
                }
                yield return waitInterval;
            }
        }

        private bool TryInitializePlayer()
        {
            _playerCharacter = GameObject.Find(ModDefaults.PLAYER_OBJECT_NAME);
            if (_playerCharacter == null)
                return false;

            _characterComponent = _playerCharacter.GetComponent<Character>();
            if (_characterComponent == null)
            {
                _logger.Warning("AutoPot: Character component not found.");
                return false;
            }

            _maxHealth = _characterComponent.Health;
            _logger.Msg($"AutoPot: Initial max health set to {_maxHealth}");
            return true;
        }

        public void Update()
        {
            if (!ValidatePlayerState())
                return;

            ProcessHealthCheck();
        }

        private bool ValidatePlayerState()
        {
            if (_playerCharacter != null && _playerCharacter.activeSelf)
                return true;

            _playerCharacter = GameObject.Find(ModDefaults.PLAYER_OBJECT_NAME);
            if (_playerCharacter == null)
                return false;

            _characterComponent = _playerCharacter.GetComponent<Character>();
            return _characterComponent != null;
        }

        private void ProcessHealthCheck()
        {
            int currentHealth = _characterComponent.Health;
            float healthRatio = _maxHealth > 0 ? (float)currentHealth / _maxHealth : 1f;

            if (healthRatio <= _config.AutoPotHealthThreshold.Value && !_hasUsedAutoPot && !_isSimulatingKeyPress)
            {
                _logger.Msg($"AutoPot: Health is low ({currentHealth}/{_maxHealth} = {healthRatio:P}). Using health potion.");
                MelonCoroutines.Start(SimulateKeyPress());
                _hasUsedAutoPot = true;
            }
            else if (healthRatio > _config.AutoPotHealthThreshold.Value)
            {
                _hasUsedAutoPot = false;
            }

            // Update max health if current health is higher
            if (currentHealth > _maxHealth)
            {
                _maxHealth = currentHealth;
                _logger.Msg($"AutoPot: Max health updated to {_maxHealth}");
            }
        }

        private IEnumerator SimulateKeyPress()
        {
            _isSimulatingKeyPress = true;
            
            // Press '1' key (0x31)
            KeyDown(0x31);
            yield return new WaitForSeconds(0.1f);
            KeyUp(0x31);

            _logger.Msg("AutoPot: Health potion key press simulation complete.");
            _isSimulatingKeyPress = false;
        }

        #region keybd_event Interop
        [DllImport("user32.dll", SetLastError = true)]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        private const uint KEYEVENTF_KEYDOWN = 0x0;
        private const uint KEYEVENTF_KEYUP = 0x2;

        private void KeyDown(byte vk)
        {
            keybd_event(vk, 0, KEYEVENTF_KEYDOWN, UIntPtr.Zero);
        }

        private void KeyUp(byte vk)
        {
            keybd_event(vk, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
        }
        #endregion
    }
}