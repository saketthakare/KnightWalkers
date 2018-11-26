using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseCommand : ICommand
{

    public void Execute()
    {
        if (Time.timeScale.Equals(1))
        {
            Time.timeScale = 0;
            GameObject.Find("PauseButton").GetComponentInChildren<Text>().text = "Resume";
        }
        else
        {
            Time.timeScale = 1;
            GameObject.Find("PauseButton").GetComponentInChildren<Text>().text = "Pause";
        }
    }
}
