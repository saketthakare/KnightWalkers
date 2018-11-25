using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour {

	public Transform player;

	void Update () {
		if(player != null)
		{
			if (gameObject.name == "ScoreText")
				GetComponent<UnityEngine.UI.Text>().text = "Score: "+ (GM.totalTime*105 + GM.coinTotal*2).ToString("0");
			if (gameObject.name == "CoinText")
				GetComponent<UnityEngine.UI.Text>().text = "Coins : " + GM.coinTotal.ToString("0");
		}
	}
}
