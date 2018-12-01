using System;

public class Leaderboard : LeaderbaordOperations
{
    public override void add(string playername, int score)
    {
        server.addScore(playername, score);
    }

    public override void fetch(int playerId)
    {
        server.fetchScore(playerId);
    }
}
