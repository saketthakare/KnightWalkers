using UnityEngine;
using UnityEngine.UI;

public class GameController
{
    private float volume;
    private bool musicOption;
    private string player = "john";
    private string userName = "John Snow";
    private static GameController instance = null;

    private GameController()
    {
        volume = 0.02f;
        musicOption = true;
    }

    public static GameController GetInstance()
    {
        if (instance == null)
            instance = new GameController();
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

    public string GetPlayer()
    {
        return player;
    }

    public string GetUserName()
    {
        return userName;
    }

    public void SetVolume(float vol)
    {
        volume = vol;
    }

    public void SetMusicOption(bool option)
    {
        musicOption = option;
    }

    public void SetPlayer(string player)
    {
        this.player = player;
    }

    public void SetUserName(string name)
    {
        userName = name;
    }
}
