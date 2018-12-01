using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardServer : MonoBehaviour, ILeaderboardAPI
{
    readonly string webUrl = "https://teaminvictus.herokuapp.com";

    public Text player1;
    public Text player2;
    public Text player3;
    public Text player4;
    public Text player5;

    public Text score1;
    public Text score2;
    public Text score3;
    public Text score4;
    public Text score5;

    public Text currentRank;
    public int currentRunId = 501;
    
    void Start()
    {
        player1.text = "Loading...";
        player2.text = "Loading...";
        player3.text = "Loading...";
        player4.text = "Loading...";
        player5.text = "Loading...";
    }


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
        {
            int m;
            try
            {
                m = Int32.Parse(www.text);
            }
            catch (FormatException e)
            {
                m = 501;
                print(e.ToString());
            }
            fetchScore(m);
            print("Upload Successful");
        }
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
        for (int i = 0; i < entries.Length; i++)
        {
            string[] entryInfo = entries[i].Split(new char[] { '|' });
            if (i == 0)
            {
                currentRank.text = entryInfo[3].ToString();
                continue;
            }
            string playername = entryInfo[1];
            string score = entryInfo[2];
            if (i == 1)
            {
                player1.text = playername;
                score1.text = score;
                continue;
            }
            if (i == 2)
            {
                player2.text = playername;
                score2.text = score;
                continue;
            }
            if (i == 3)
            {
                player3.text = playername;
                score3.text = score;
                continue;
            }
            if (i == 4)
            {
                player4.text = playername;
                score4.text = score;
                continue;
            }
            if (i == 5)
            {
                player5.text = playername;
                score5.text = score;
                continue;
            }

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
