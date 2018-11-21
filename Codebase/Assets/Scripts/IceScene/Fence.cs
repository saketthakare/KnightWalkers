using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Fence : MonoBehaviour, IObstacle {
    
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
        // Debug.Log("Fence OnCollisionEnter");
        notifyPlayer();
    }

    public void notifyPlayer()
    {
        // Debug.Log("Fence notify Player");
        player.destroyObject();
    }

    public void attachPlayer(sphere player)
    {
        // Debug.Log("Fence attach Player");
        this.player = player;
    }
} 
