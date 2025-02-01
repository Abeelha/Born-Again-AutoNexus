using System.Runtime.InteropServices;
using MelonLoader;
using AutoNexus.Constants;

namespace AutoNexus.Utils
{
    public class SoundManager
    {
        private readonly MelonLogger.Instance _logger;

        [DllImport("winmm.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool PlaySound(string pszSound, System.IntPtr hmod, uint fdwSound);

        public SoundManager(MelonLogger.Instance logger)
        {
            _logger = logger;
            EnsureSoundDirectory();
        }

        private void EnsureSoundDirectory()
        {
            string soundsFolder = "Mods/sounds";
            if (!System.IO.Directory.Exists(soundsFolder))
            {
                System.IO.Directory.CreateDirectory(soundsFolder);
                _logger.Msg($"Created sounds folder at: {soundsFolder}");
            }
        }

        public void PlayToggleSound(bool isEnabled)
        {
            string soundFilePath = isEnabled ? "Mods/sounds/enable.wav" : "Mods/sounds/disable.wav";

            if (System.IO.File.Exists(soundFilePath))
            {
                if (!PlaySound(soundFilePath, System.IntPtr.Zero, ModDefaults.Sound.SND_ASYNC | ModDefaults.Sound.SND_FILENAME))
                {
                    _logger.Error($"Failed to play sound file: {soundFilePath}");
                }
            }
            else
            {
                _logger.Error($"Sound file not found: {soundFilePath}");
            }
        }
    }
}