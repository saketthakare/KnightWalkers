using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFactory : IObstacleFactory {

	public void createObstacle(GameObject fire,float x, float y, float z)
	{
		GameObject clonefire = MonoBehaviour.Instantiate(fire,new Vector3(x,y,z),Quaternion.identity) as GameObject;
	}
}
