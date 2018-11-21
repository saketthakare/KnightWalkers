using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceFactory : IObstacleFactory {

	public void createObstacle(GameObject fence,float x, float y, float z)
	{
		//GameObject clonefence = MonoBehaviour.Instantiate(fence,new Vector3(x,y,z),Quaternion.identity) as GameObject;
		GameObject clonefence = MonoBehaviour.Instantiate(fence,new Vector3(x,y,z),Quaternion.Euler(0, 90, 0)) as GameObject;
	}
}
