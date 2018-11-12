using UnityEngine;

public class Menu : MonoBehaviour, IMenu
{
    Command quitCommand = new QuitCommand();
    public void Play()
    {
        //Application.loadedLevel()
    }

    public void Help()
    {
        //Application.LoadLevel("Help");
    }

    public void Settings()
    {
        //Application.LoadLevel("Settings");
    }

    public void Quit()
    {
       quitCommand.Execute();
    }
}
