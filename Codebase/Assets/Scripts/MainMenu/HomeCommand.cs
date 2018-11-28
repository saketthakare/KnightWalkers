using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeCommand : ICommand
{

    public void Execute()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        if (Time.timeScale.Equals(0))
            Time.timeScale = 1;
        GM.coinTotal = 0;
        GM.totalTime = 0;
    }
}
