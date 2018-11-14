using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitCommand : ICommand
{

    public void Execute()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
