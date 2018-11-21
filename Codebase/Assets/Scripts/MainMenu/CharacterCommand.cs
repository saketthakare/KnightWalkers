using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterCommand : ICommand
{

    public void Execute()
    {
        GameObject.FindWithTag("MainMenu").SetActive(false);
        GameObject.Find("Canvas").transform.Find("CharacterSelectionMenu").gameObject.SetActive(true);
    }
}
