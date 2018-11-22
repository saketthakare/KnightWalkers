using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IceScene : MonoBehaviour {
    
    public float zScenePos = 216;
    public float zObjPos = 20;
    public float zPlayerPos;
    
    public Transform base1;
    public Transform base2;
    
    public Transform capsule;
    public Transform fence;
    public Transform fire;
    public Transform fire2;
    
    public int randNo;
    public int randObj;
    public int randLane;
    public float laneNo;

	public GameObject fireObj;
	public GameObject fenceObj;
	public GameObject player;

	public Fence newfenceobject;
	public Fire newfireobject;

	IObstacleFactory objfact;
    
    //ObstacleFactory obsFactory = new ObstacleFactory();

    // Use this for initialization

    void Start () {
		Instantiate(base1,new Vector3(0,0,72),base1.rotation);
		Instantiate(base2,new Vector3(0,0,108),base1.rotation);
		Instantiate(base2,new Vector3(0,0,144),base1.rotation);
		Instantiate(base1,new Vector3(0,0,180),base1.rotation);	
	}
	
	// Update is called once per frame
	void Update () {
		
		zPlayerPos = GameObject.Find("Sphere").GetComponent<Transform>().position.z;
		
		if((zScenePos-zPlayerPos)  < 300)
		{
			randNo = UnityEngine.Random.Range(0,10);
			
			if(randNo<5)
			{
				Instantiate(base1,new Vector3(0,0,zScenePos),base1.rotation);
				zScenePos += 36;
			}
			else
			{
				Instantiate(base2,new Vector3(0,0,zScenePos),base2.rotation);
				zScenePos += 36;
			}	
		}
		

		if((zObjPos-zPlayerPos)  < 300)
		{
		
			randObj = UnityEngine.Random.Range(0,50);
			randLane = UnityEngine.Random.Range(1,4);
			
			if(randLane==1)
				laneNo = -1.5f;
			else if(randLane==3)
				laneNo = 0;
			else
				laneNo = 1.5f;	
			
			if(randObj>15 && randObj<=25)
			{
				Debug.Log("random creation of fires");
				objfact = new FireFactory();
				newfireobject = (Fire)objfact.createObstacle(fireObj,laneNo,1.5f,zObjPos);

				// Rigidbody fireRigidBody = newfireobject.obj.AddComponent<Rigidbody>();
				// fireRigidBody.useGravity = false;

				BoxCollider fireBoxCollider = newfireobject.obj.AddComponent<BoxCollider>();
				 fireBoxCollider.isTrigger = true;

				newfireobject.attachPlayer(player.GetComponent<sphere>());
				
				zObjPos += randObj;
			}
			else if(randObj>25 && randObj<=40)
			{
				Debug.Log("random creation of fences");
				objfact = new FenceFactory();
				newfenceobject = (Fence)objfact.createObstacle(fenceObj,laneNo,0.75f,zObjPos);

				// Rigidbody fenceRigidBody = newfenceobject.obj.AddComponent<Rigidbody>();
				// fenceRigidBody.useGravity = false;
				
				BoxCollider fenceBoxCollider = newfenceobject.obj.AddComponent<BoxCollider>();
				fenceBoxCollider.isTrigger = true;
				
				newfenceobject.attachPlayer(player.GetComponent<sphere>());
				
				zObjPos += randObj;
			}
			else if(randObj>45)
			{
				Instantiate(capsule,new Vector3(laneNo,1,zObjPos),capsule.rotation);
				zObjPos += 25;
			}
		}
	}
}