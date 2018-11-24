using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFactory : IObjectFactory {

	public IObject createObstacle(GameObject coin,float x, float y, float z)
	{
		GameObject o =  MonoBehaviour.Instantiate(coin,new Vector3(x,y,z),Quaternion.Euler(0, 0, 90)) as GameObject;	
		Coin coinScript = o.AddComponent<Coin>();

		IObject obs = coinScript;
		return obs;
	}
}