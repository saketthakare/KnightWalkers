﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayCommand : ICommand
{

    public void Execute()
    {
        SceneManager.LoadScene("IceScene", LoadSceneMode.Single);
    }
}
