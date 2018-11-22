using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class sphere : MonoBehaviour {

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

        if (other.gameObject.name.StartsWith("coin"))
        {
            GM.coinTotal += 10;
        }
    }
    
    private void OnCollisionEnter(Collision other)
    {
        //if(other.gameObject.tag == "lethal")
        //{
        //    Destroy(gameObject);
        //    GM.horizontalVelocity = 0;
        //}
        //else
        if(other.gameObject.tag == "boost")
        {
            Destroy(other.gameObject);
            GM.horizontalVelocity = 25;
            StartCoroutine(stopBoost());
        }
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
		GM.horizontalVelocity = 12;		
    }

    public void destroyObject()
    {
        Destroy(this.gameObject);
        GM.horizontalVelocity = 0;
        notifyObserver();
    }



    public void notifyObserver(){
        playerHealth.TakeDamage(collisionDamage);
    }

}
