using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Fire : MonoBehaviour, IObstacle {

    sphere player;
    public GameObject obj;

    private void Awake()
    {
        obj = this.gameObject;        
    }
    
    private void Start() 
    {
        
    }

    // private void Update()
    // {
    //     Debug.Log("update called");
    //     // if(player != null && newfenceobject!= null && newfireobject != null)
	// 	// {
	// 		float distance1 = Vector3.Distance(player.gameObject.transform.position, transform.position);
	// 		float distance2 = Vector3.Distance(this.gameObject.transform.position, transform.position);
	// 		// float distance3 = Vector3.Distance(newfireobject.obj.transform.position, transform.position);
			
	// 		float distanceFire = Math.Abs(distance1 - distance2);
	// 		// float distanceFence = Math.Abs(distance1 - distance2);
			
    //         Debug.Log("distance1 : "+distance1);
    //         Debug.Log("distance2 : "+distance2);
    //         Debug.Log("distanceFire : "+distanceFire);


	// 		if(distanceFire==0)
	// 		{
	// 			this.notifyPlayer();
	// 		}
	// 		// if(distanceFence == 0)
	// 		// {
	// 		// 	newfenceobject.notifyPlayer();
	// 		// }
	// 	// }
    // }

    private void OnCollisionEnter(Collision other)
    {
        // Debug.Log("Fire OnCollisionEnter");
        notifyPlayer();
    }


    public void attachPlayer(sphere player)
    {
        // Debug.Log("Fire attach Player");
        this.player = player;
    }
    
    public void notifyPlayer()
    {
        // Debug.Log("Fire notify Player"+player);
        player.destroyObject();
    }
} 