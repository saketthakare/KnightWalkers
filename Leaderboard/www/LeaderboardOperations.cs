using System;

public abstract class LeaderbaordOperations
{
    public ILeaderboardAPI server { get; set; }
    public abstract void add(string playername, int score);
    public abstract void fetch(int playerId);
}
