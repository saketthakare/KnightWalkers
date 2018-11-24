using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionFactory : IObjectFactory {

	public IObject createObstacle(GameObject potion,float x, float y, float z)
	{
		GameObject o =  MonoBehaviour.Instantiate(potion,new Vector3(x,y,z),Quaternion.Euler(0, 0, 35)) as GameObject;	
		HealthPotion potionScript = o.AddComponent<HealthPotion>();

		IObject obs = potionScript;
		return obs;
	}
}
