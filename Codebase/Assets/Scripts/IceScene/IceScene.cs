using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceScene : MonoBehaviour {
    
    public float zScenePos = 216;
    public float zObjPos = 20;
    public float zPlayerPos;
    
    public Transform base1;
    public Transform base2;
    
    public Transform capsule;
    public Transform fence;
    public Transform fire;
    
    public int randNo;
    public int randObj;
    public int randLane;
    public float laneNo;
    

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
		
		if((zScenePos-zPlayerPos)  < 200)
		{
			randNo = Random.Range(0,10);
			
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
		
		
		randObj = Random.Range(0,50);
		randLane = Random.Range(1,4);
		
		if(randLane==1)
			laneNo = -1.5f;
		else if(randLane==3)
			laneNo = 0;
		else
			laneNo = 1.5f;	
		
		if(randObj>15 && randObj<=25)
		{
			
			Instantiate(fire,new Vector3(laneNo,1.5f,zObjPos),fire.rotation);
			zObjPos += randObj;
		}
		else if(randObj>25 && randObj<=40)
		{
			Instantiate(fence,new Vector3(laneNo,0.75f,zObjPos),fence.rotation);
			zObjPos += randObj;
		}
		else if(randObj>45)
		{
			Instantiate(capsule,new Vector3(laneNo,1,zObjPos),capsule.rotation);
			zObjPos += 25;
		}
	}
}
