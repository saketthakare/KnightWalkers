using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFactory : IObjectFactory {

	public IObject createObstacle(GameObject fire,float x, float y, float z)
	{
		GameObject o =  MonoBehaviour.Instantiate(fire,new Vector3(x,y,z),Quaternion.identity) as GameObject;	
		Fire fireScript = o.AddComponent<Fire>();

		IObject obs = fireScript;
		return obs;
	}
}
