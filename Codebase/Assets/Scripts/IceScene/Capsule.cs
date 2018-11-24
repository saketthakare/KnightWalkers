using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Capsule : MonoBehaviour, IObject {
    
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
        notifyPlayer("boost");
    }

    public void notifyPlayer(string objectType)
    {
        destroyCapsule();
        player.updateSphere(objectType);
    }

    public void attachPlayer(sphere player)
    {
        this.player = player;
    }

    public void destroyCapsule()
    {
        Destroy(this.gameObject);
    }

} 
