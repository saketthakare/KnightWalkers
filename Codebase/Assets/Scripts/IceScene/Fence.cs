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
        notifyPlayer();
    }

    public void notifyPlayer()
    {
        player.updateSphere();
    }

    public void attachPlayer(sphere player)
    {
        this.player = player;
    }
} 
