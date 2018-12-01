public interface ILeaderboardAPI
{
    void addScore(string playername, int score);
    void fetchScore(int playerId);
}
