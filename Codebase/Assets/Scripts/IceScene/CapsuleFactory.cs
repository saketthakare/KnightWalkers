using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleFactory : IObjectFactory {

	public IObject createObstacle(GameObject capsule,float x, float y, float z)
	{
		GameObject o =  MonoBehaviour.Instantiate(capsule,new Vector3(x,y,z),Quaternion.Euler(0, 0, 90)) as GameObject;	
		Capsule capsuleScript = o.AddComponent<Capsule>();

		IObject obs = capsuleScript;
		return obs;
	}
}
