using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider volumeSlider;
    public Toggle musicToggler;
    private readonly GlobalAudioController globalAudioController = GlobalAudioController.GetInstance();

    void Start(){
        if (audioSource != null)
        {
            audioSource.enabled = globalAudioController.GetMusicOption();
            audioSource.volume = globalAudioController.GetVolume();
        }
        if (volumeSlider != null)
        {
            volumeSlider.value = globalAudioController.GetVolume();
            volumeSlider.onValueChanged.AddListener(delegate { ControlVolume(); });
        }
        if (musicToggler != null)
        {
            musicToggler.onValueChanged.AddListener(delegate { ToggleAudio(); });
        }
    }

    private void ToggleAudio()
    {
        audioSource.enabled = !audioSource.enabled;
        /*if (audioSource.volume.Equals(0.0f))
        {
            audioSource.volume = globalAudioController.GetVolume();
        }
        else
            audioSource.volume = 0.0f;*/
        globalAudioController.SetMusicOption(audioSource.enabled);
    }

    private void ControlVolume()
    {
        audioSource.volume = volumeSlider.value;
        globalAudioController.SetVolume(audioSource.volume);
    }
}
