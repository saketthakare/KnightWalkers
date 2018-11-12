using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitCommand : Command
{

    public override void Execute()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
