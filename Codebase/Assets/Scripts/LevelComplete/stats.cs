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
        if (gameObject.name == "TimeTotal")
            GetComponent<UnityEngine.UI.Text>().text = "Time : " + GM.totalTime;
        else if (gameObject.name == "CoinTotal")
            GetComponent<UnityEngine.UI.Text>().text = "Coins : " + GM.coinTotal;
    }
}
