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
    public int collisionDamage = 10;

    // Use this for initialization
    void Start () {

	}

    private void Awake()
    {
        playerHealth = this.GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update () {
        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, GM.verticalVelocity, GM.horizontalVelocity);

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
        if(other.gameObject.tag == "lethal")
        {
            notifyObserver();
        }

        // if (other.gameObject.name.StartsWith("coin"))
        // {
        //     GM.coinTotal += 10;
        // }
    }
    
    private void OnCollisionEnter(Collision other)
    {
        // if(other.gameObject.tag == "boost")
        // {
        //     Destroy(other.gameObject);
        //     GM.horizontalVelocity = 25;
        //     StartCoroutine(stopBoost());
        // }
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
            notifyObserver();
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
    }

    public void notifyObserver(){
        playerHealth.TakeDamage(collisionDamage);
    }
}
