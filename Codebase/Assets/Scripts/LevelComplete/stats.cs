using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class stats : MonoBehaviour {

	void Update () {

        if (gameObject.name == "TimeTotal")
            GetComponent<UnityEngine.UI.Text>().text = "Time : " + GM.totalTime.ToString("0");
        if (gameObject.name == "CoinTotal")
            GetComponent<UnityEngine.UI.Text>().text = "Coins : " + GM.coinTotal.ToString("0");
        if (gameObject.name == "ScoreTotal")
            GetComponent<UnityEngine.UI.Text>().text = "Score : " + (GM.totalTime*105 + GM.coinTotal*2).ToString("0");
        if (gameObject.name == "TotalCost")
            GetComponent<UnityEngine.UI.Text>().text = "Cost : " + GM.coinTotal.ToString("0");
       
    }
}
