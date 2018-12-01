using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardServer : MonoBehaviour, ILeaderboardAPI
{
    readonly string webUrl = "https://teaminvictus.herokuapp.com";
    public Text scoreListText;
    public HighScoreList[] highscoresList;
    public int currentRunId = 0;

    public void addScore(string playername, int score)
    {
        StartCoroutine(UploadNewHighscore(playername, score));
    }

    public void fetchScore(int playerId)
    {
        StartCoroutine(DownloadHighscoresFromDatabase(playerId));
    }

    IEnumerator UploadNewHighscore(string playername, int score)
    {
        WWW www = new WWW(webUrl + "/add/" + WWW.EscapeURL(playername) + "/" + score);
        yield return www;
        if (string.IsNullOrEmpty(www.error))
            print("Upload Successful");
        else
        {
            print("Error uploading: " + www.error);
        }
    }

    IEnumerator DownloadHighscoresFromDatabase(int id)
    {
        WWW www = new WWW(webUrl + "/" + WWW.EscapeURL(id.ToString()));
        yield return www;

        if (string.IsNullOrEmpty(www.error))
            FormatHighscores(www.text);
        else
        {
            print("Error Downloading: " + www.error);
        }
    }

    private void FormatHighscores(string textStream)
    {
        string[] entries = textStream.Split(new char[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
        highscoresList = new HighScoreList[entries.Length];
        scoreListText.text = "";
        for (int i = 1; i < entries.Length; i++)
        {
            string[] entryInfo = entries[i].Split(new char[] { '|' });
            string playername = entryInfo[1];
            int score = int.Parse(entryInfo[2]);
            highscoresList[i] = new HighScoreList(playername, score);
            print(highscoresList[i].playername + ": " + highscoresList[i].score);
            scoreListText.text = scoreListText.text + highscoresList[i].playername + highscoresList[i].score;
            scoreListText.text = scoreListText.text + "\n";
        }
    }

}


public struct HighScoreList
{
    public string playername;
    public int score;

    public HighScoreList(string _playername, int _score)
    {
        playername = _playername;
        score = _score;
    }

}
