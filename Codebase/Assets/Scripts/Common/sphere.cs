using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class sphere : MonoBehaviour, ISphereSubject, ISphereObserver {

    public KeyCode moveL;
    public KeyCode moveR;

    public float horizVel = 0;
    public int laneNum = 2;
    public string controllocked = "n";

    public PlayerHealth playerHealth;
    public int collisionDamage = 25;

    private void Awake()
    {
        playerHealth = this.GetComponent<PlayerHealth>();
    }

    void Update () {
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, GM.verticalVelocity, GM.horizontalVelocity);
        GM.totalTime += Time.deltaTime;
        if(Input.GetKeyDown(moveL) && laneNum > 1 && controllocked == "n")
        {
            horizVel = -3;
            StartCoroutine(stopSlide());
            laneNum -= 1;
            controllocked = "y";
        }

        if (Input.GetKeyDown(moveR) && (laneNum < 3) && (controllocked == "n"))
        {
            horizVel = 3;
            StartCoroutine(stopSlide());
            laneNum += 1;
            controllocked = "y";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // if(other.gameObject.tag == "lethal")
        // {
        //     notifyObserver("lethal");
        // }
    }
    
    private void OnCollisionEnter(Collision other)
    {
       
    }

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;
        controllocked = "n";
    }
    
    IEnumerator stopBoost()
    {
		yield return new WaitForSeconds(8);
		GM.horizontalVelocity = 20;		
    }

    public void attach(IObject o)
    {

    }

    public void updateSphere(String objectType)
    {
        if(objectType == "lethal")
        {
            notifyObserver(objectType);
        }
        else if(objectType == "boost")
        {
            GM.horizontalVelocity = 30;
            StartCoroutine(stopBoost());
        }
        else if(objectType == "coin")
        {
             GM.coinTotal += 10;
        }
        else if(objectType == "healthboost")
        {
            notifyObserver(objectType);
        }
    }

    public void notifyObserver(String objectType){
        if(objectType == "lethal")
        {
            playerHealth.TakeDamage(collisionDamage);
        }
        else
        {
            playerHealth.BoostHealth();
        }
    }
}
