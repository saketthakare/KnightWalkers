using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateLeaderboard : MonoBehaviour {
    //public LeaderboardServer lb;
    private readonly GameController gameController = GameController.GetInstance();
    public LeaderboardServer server;
	void Start () {
        server = FindObjectOfType(typeof(LeaderboardServer)) as LeaderboardServer;
        add(gameController.GetUserName(), ((int)GM.totalTime * 105 + GM.coinTotal * 2));
	}
	
	void Update () {
		
	}


    public void add(string playername, int score)
    {
        server.addScore(playername, score);
    }

    public void fetch(int playerId)
    {
        server.fetchScore(playerId);
    }
}
