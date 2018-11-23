﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IceScene : MonoBehaviour {
    
    public float zScenePos = 216;
    public float zObjPos = 20;
	public float zWallPos = 0;
    public float zPlayerPos;
    
    public Transform base1;
    public Transform base2;
	public Transform wall_l;
	public Transform wall_r;
    
    public Transform capsule;
    public Transform fence;
    public Transform fire;
    
    public int randNo;
    public int randObj;
    public int randLane;
    public float laneNo;

	public GameObject fireObj;
	public GameObject fenceObj;
	public GameObject capsuleObj;
	public GameObject player;

	public Fence newfenceobject;
	public Fire newfireobject;
	public Capsule newcapsuleobject;

	IObjectFactory objfact;
    
    void Start () {
		Instantiate(base1,new Vector3(0,0,72),base1.rotation);
		Instantiate(base2,new Vector3(0,0,108),base1.rotation);
		Instantiate(base2,new Vector3(0,0,144),base1.rotation);
		Instantiate(base1,new Vector3(0,0,180),base1.rotation);

		//Instantiate(wall_l,new Vector3(-11,6,0),wall_l.rotation);
		//Instantiate(wall_l,new Vector3(-11,6,36),wall_l.rotation);
		//Instantiate(wall_l,new Vector3(-11,6,72),wall_l.rotation);

		//Instantiate(wall_r,new Vector3(10,4,0),wall_r.rotation);
		//Instantiate(wall_r,new Vector3(10,4,36),wall_r.rotation);
		//Instantiate(wall_r,new Vector3(10,4,72),wall_r.rotation);

	}
	
	void Update () {
		
		GameObject gobj = GameObject.Find("Sphere");
		if(gobj != null)
		{
			zPlayerPos =gobj.GetComponent<Transform>().position.z;
			
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

			Instantiate(wall_l,new Vector3(-11,6,zWallPos),wall_l.rotation);
			Instantiate(wall_r,new Vector3(10,4,zWallPos),wall_r.rotation);
			zWallPos += 36;			

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
					objfact = new FireFactory();
					newfireobject = (Fire)objfact.createObstacle(fireObj,laneNo,1.5f,zObjPos);

					BoxCollider fireBoxCollider = newfireobject.obj.AddComponent<BoxCollider>();
					fireBoxCollider.isTrigger = true;

					newfireobject.attachPlayer(player.GetComponent<sphere>());
					
					zObjPos += randObj;
				}
				else if(randObj>25 && randObj<=40)
				{
					objfact = new FenceFactory();
					newfenceobject = (Fence)objfact.createObstacle(fenceObj,laneNo,0.75f,zObjPos);

					BoxCollider fenceBoxCollider = newfenceobject.obj.AddComponent<BoxCollider>();
					fenceBoxCollider.isTrigger = true;
					
					newfenceobject.attachPlayer(player.GetComponent<sphere>());
					
					zObjPos += randObj;
				}
				else if(randObj>45)
				{
					objfact = new CapsuleFactory();

					newcapsuleobject = (Capsule)objfact.createObstacle(capsuleObj,laneNo,1,zObjPos);
					// Instantiate(capsule,new Vector3(laneNo,1,zObjPos),capsule.rotation);
					CapsuleCollider capsuleCollider = newcapsuleobject.obj.AddComponent<CapsuleCollider>();
					capsuleCollider.isTrigger = true;
					
					newcapsuleobject.attachPlayer(player.GetComponent<sphere>());
					zObjPos += 25;
				}
			}
		}
	}
}