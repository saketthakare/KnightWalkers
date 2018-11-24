using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealthPotion : MonoBehaviour, IObject {
    
    sphere player;
    public GameObject obj;

    private void Awake()
    {
        obj = this.gameObject;  
        // player = this.GetComponent<sphere>();      
    }
    
    private void Start() 
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        notifyPlayer("healthboost");
    }

    public void notifyPlayer(String objectType)
    {
        destroyHealthPotion();
        player.updateSphere(objectType);
    }

    public void attachPlayer(sphere player)
    {
        this.player = player;
    }

    public void destroyHealthPotion()
    {
        Destroy(this.gameObject);
    }

} 
