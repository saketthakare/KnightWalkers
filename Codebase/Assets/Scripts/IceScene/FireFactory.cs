using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFactory : IObstacleFactory {

	public IObstacle createObstacle(GameObject fire,float x, float y, float z)
	{
		GameObject o =  MonoBehaviour.Instantiate(fire,new Vector3(x,y,z),Quaternion.identity) as GameObject;	
		Fire fireScript = o.AddComponent<Fire>();

		IObstacle obs = fireScript;
		return obs;
	}
}
