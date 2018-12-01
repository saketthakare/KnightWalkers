using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILeaderboardAPI
{
    void addScore(string playername, int score);
    void fetchScore(int playerId);
}
