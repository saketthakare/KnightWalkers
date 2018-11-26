using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeCommand : ICommand
{

    public void Execute()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
