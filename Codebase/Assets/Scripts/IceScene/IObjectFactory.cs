using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObjectFactory 
{
	IObject createObstacle(GameObject obstacle,float x, float y, float z);
}
