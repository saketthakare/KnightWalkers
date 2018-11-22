using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Fence : MonoBehaviour, IObject {
    
    sphere player;
    public GameObject obj;

    private void Awake()
    {
        obj = this.gameObject;        
    }
    
    private void Start() 
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        notifyPlayer("lethal");
    }

    public void notifyPlayer(String objectType)
    {
        player.updateSphere(objectType);
    }

    public void attachPlayer(sphere player)
    {
        this.player = player;
    }
} 
