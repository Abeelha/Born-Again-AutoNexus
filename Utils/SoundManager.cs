using System.Runtime.InteropServices;
using AutoNexus.Constants;

namespace AutoNexus.Utils;

public class SoundManager
{
    private readonly MelonLogger.Instance _logger;

    public SoundManager(MelonLogger.Instance logger)
    {
        _logger = logger;
        EnsureSoundDirectory();
    }

    [DllImport("winmm.dll", SetLastError = true, CharSet = CharSet.Unicode)]
    private static extern bool PlaySound(string pszSound, IntPtr hmod, uint fdwSound);

    private void EnsureSoundDirectory()
    {
        var soundsFolder = "Mods/sounds";
        if (!Directory.Exists(soundsFolder))
        {
            Directory.CreateDirectory(soundsFolder);
            _logger.Msg($"Created sounds folder at: {soundsFolder}");
        }
    }

    public void PlayAutoNexusToggleSound(bool isEnabled)
    {
        var soundFilePath = isEnabled ? "Mods/sounds/enableNexusInsta.wav" : "Mods/sounds/disableNexusInsta.wav";
        if (File.Exists(soundFilePath))
        {
            if (!PlaySound(soundFilePath, IntPtr.Zero, ModDefaults.Sound.SND_ASYNC | ModDefaults.Sound.SND_FILENAME))
            {
                _logger.Error($"Failed to play sound file: {soundFilePath}");
            }
        }
        else
        {
            _logger.Error($"Sound file not found: {soundFilePath}");
        }
    }

    public void PlayAutoPotToggleSound(bool isEnabled)
    {
        var soundFilePath = isEnabled ? "Mods/sounds/enableAutoPot.wav" : "Mods/sounds/disableAutoPot.wav";
        if (File.Exists(soundFilePath))
        {
            if (!PlaySound(soundFilePath, IntPtr.Zero, ModDefaults.Sound.SND_ASYNC | ModDefaults.Sound.SND_FILENAME))
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