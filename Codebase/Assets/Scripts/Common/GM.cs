using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {

    public static float verticalVelocity = 0;
    public static float horizontalVelocity = 20;

    public static int coinTotal = 0;
    public static float totalTime = 0;

    // Use this for initialization

    public float zScenePos = 216;
    
    public Transform base1;
    public Transform base2;
    
    // Use this for initialization

    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        totalTime += Time.deltaTime;
    }
		
}
