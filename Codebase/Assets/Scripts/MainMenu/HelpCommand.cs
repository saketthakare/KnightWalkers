using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpCommand : ICommand
{

    public void Execute() 
    {
        GameObject.FindWithTag("MainMenu").SetActive(false);
        GameObject.Find("Canvas").transform.Find("HelpMenu").gameObject.SetActive(true);
    }
}
