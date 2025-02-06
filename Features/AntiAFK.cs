using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using MelonLoader;

namespace AutoNexus.Features
{
    public class AntiAFK
    {
        private readonly MelonLogger.Instance _logger;
        private float _lastWASDTime;
        private bool _isSimulating;

        private const float IdleThreshold = 115f;
        private const float DKeyPressDuration = 0.1f;

        public AntiAFK(MelonLogger.Instance logger)
        {
            _logger = logger;
            _lastWASDTime = Time.time;
        }
        public void Update()
        {
            CheckWASDInput();

            if (!_isSimulating && (Time.time - _lastWASDTime) >= IdleThreshold)
            {
                MelonCoroutines.Start(SimulateDKeyPress());
            }
        }
        private void CheckWASDInput()
        {
            if (Input.GetKeyDown(KeyCode.W) ||
                Input.GetKeyDown(KeyCode.A) ||
                Input.GetKeyDown(KeyCode.S) ||
                Input.GetKeyDown(KeyCode.D))
            {
                _lastWASDTime = Time.time;
            }
        }
        private IEnumerator SimulateDKeyPress()
        {
            _isSimulating = true;
            _logger.Msg("Idle detected. Simulating D key press for 0.5 seconds using keybd_event.");

            KeyDown(0x44);
            yield return new WaitForSeconds(DKeyPressDuration);
            KeyUp(0x44);

            _logger.Msg("D key simulation complete.");
            _lastWASDTime = Time.time;
            _isSimulating = false;
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
