using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider volumeSlider;
    public Toggle musicToggler;
    private readonly GameController gameController = GameController.GetInstance();

    void Start(){
        if (audioSource != null)
        {
            audioSource.enabled = gameController.GetMusicOption();
            audioSource.volume = gameController.GetVolume();
        }
        if (volumeSlider != null)
        {
            volumeSlider.value = gameController.GetVolume();
            volumeSlider.onValueChanged.AddListener(delegate { ControlVolume(); });
        }
        if (musicToggler != null)
        {
            musicToggler.isOn = gameController.GetMusicOption();
            musicToggler.onValueChanged.AddListener(delegate { ToggleAudio(); });
        }
    }

    private void Update()
    {
        if (musicToggler != null)
        {
            musicToggler.isOn = gameController.GetMusicOption();
        }
        audioSource.enabled = gameController.GetMusicOption();
        audioSource.volume = gameController.GetVolume();
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
        gameController.SetMusicOption(audioSource.enabled);
    }

    private void ControlVolume()
    {
        audioSource.volume = volumeSlider.value;
        gameController.SetVolume(audioSource.volume);
    }
}
