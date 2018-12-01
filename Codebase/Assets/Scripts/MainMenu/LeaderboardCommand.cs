using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeaderboardCommand : ICommand
{

    public void Execute()
    {
        SceneManager.LoadScene("Leaderboard", LoadSceneMode.Single);
    }
}
