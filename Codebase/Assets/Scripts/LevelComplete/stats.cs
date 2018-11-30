using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class stats : MonoBehaviour {

	void Update () {

        if (gameObject.name == "TimeTotal")
            GetComponent<UnityEngine.UI.Text>().text = "Time :";
        if (gameObject.name == "TimeTotalText")
            GetComponent<UnityEngine.UI.Text>().text = GM.totalTime.ToString("0");
        if (gameObject.name == "CoinTotal")
            GetComponent<UnityEngine.UI.Text>().text = "Coins : ";
        if (gameObject.name == "CoinTotalText")
            GetComponent<UnityEngine.UI.Text>().text = GM.coinTotal.ToString("0");
        if (gameObject.name == "ScoreTotal")
            GetComponent<UnityEngine.UI.Text>().text = "Score : ";
        if (gameObject.name == "ScoreTotalText")
            GetComponent<UnityEngine.UI.Text>().text = (GM.totalTime * 105 + GM.coinTotal * 2).ToString("0");

    }
}
