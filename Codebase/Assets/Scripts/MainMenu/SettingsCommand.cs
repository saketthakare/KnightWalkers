using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsCommand : ICommand
{

    public void Execute()
    {
        GameObject.FindWithTag("MainMenu").SetActive(false);
        GameObject.Find("Canvas").transform.Find("SettingsMenu").gameObject.SetActive(true);
    }
}
