using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceScene : MonoBehaviour {
    
    public float zScenePos = 216;
    
    public Transform base1;
    public Transform base2;
    
    public int randNo;

    // Use this for initialization
    void Start () {
		Instantiate(base1,new Vector3(0,0,72),base1.rotation);
		Instantiate(base2,new Vector3(0,0,108),base1.rotation);
		Instantiate(base2,new Vector3(0,0,144),base1.rotation);
		Instantiate(base1,new Vector3(0,0,180),base1.rotation);
	}
	
	// Update is called once per frame
	void Update () {
	
		if(zScenePos < 500)
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
		
	}
}
