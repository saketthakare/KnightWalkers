using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObstacle 
{
	 void notifyPlayer();
     void attachPlayer(sphere player);
}
