using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class stats : MonoBehaviour {
 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("gameObject.name: " + gameObject.name);
        if (gameObject.name == "TimeTotal")
        {
            Debug.Log("GM.totalTime: " + GM.totalTime);
            GetComponent<UnityEngine.UI.Text>().text = "Time : " + Math.Round(GM.totalTime,3);
        }
        else if (gameObject.name == "CoinTotal")
            GetComponent<UnityEngine.UI.Text>().text = "Coins : " + GM.coinTotal;
        else if (gameObject.name == "ScoreTotal")
            GetComponent<UnityEngine.UI.Text>().text = "Score : " + GM.coinTotal;
    }
}
