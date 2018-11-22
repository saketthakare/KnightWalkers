using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IObject
{
	void notifyPlayer(String objectType);
     void attachPlayer(sphere player);
}
