using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceFactory : IObjectFactory 
{
	public IObject createObstacle(GameObject fence,float x, float y, float z)
	{
		GameObject o =  MonoBehaviour.Instantiate(fence,new Vector3(x,y,z),Quaternion.Euler(0, 90, 0)) as GameObject;	
		Fence fenceScript = o.AddComponent<Fence>();

		IObject obs = fenceScript;
		return obs;
	}
}
