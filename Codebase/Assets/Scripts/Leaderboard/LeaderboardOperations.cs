using System;

public abstract class LeaderboardOperations
{
    public abstract void add(string playername, int score);
    public abstract void fetch(int playerId);
}
