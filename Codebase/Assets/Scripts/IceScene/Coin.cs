using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, IObject {
    
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
        notifyPlayer("coin");
    }

    public void notifyPlayer(string objectType)
    {
        destroyCoin();
        player.updateSphere(objectType);
    }

    public void attachPlayer(sphere player)
    {
        this.player = player;
    }

    public void destroyCoin()
    {
        Destroy(this.gameObject);
    }

} 
