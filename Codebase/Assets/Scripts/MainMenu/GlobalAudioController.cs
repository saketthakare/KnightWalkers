using UnityEngine;
using UnityEngine.UI;

public class GlobalAudioController
{
   private float volume;
    private bool musicOption;
    private static GlobalAudioController instance = null;

    private GlobalAudioController()
    {
        volume = 0.02f;
        musicOption = true;
    }

    public static GlobalAudioController GetInstance()
    {
        if (instance == null)
            instance = new GlobalAudioController();
        return instance;
    }

    public float GetVolume()
    {
        return volume;
    }

    public bool GetMusicOption()
    {
        return musicOption;
    }

    public void SetVolume(float vol)
    {
        volume = vol;
    }

    public void SetMusicOption(bool option)
    {
        musicOption = option;
    }
}
