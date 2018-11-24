using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour, IHealthObserver {

    public int startHealth = 100;
    public int healthBoostAmount = 10;
    public int currentHealth;
    public Slider healthSlider;
    public Image damageImage;
    public float flashSpeed = 5f;
    public Color flashColor = new Color(1f, 0f, 0f, 0.1f);

    bool isDead;
    bool damaged;

    public sphere sphere;

    private void Awake()
    {
        currentHealth = startHealth;
        sphere = this.GetComponent<sphere>();
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(damaged){
            damageImage.color = flashColor;
        }
        else{
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
	}

    public void TakeDamage(int amount){
        if (this.currentHealth <= 0)
        {
            Destroy(sphere.gameObject);
            GM.horizontalVelocity = 0;
            SceneManager.LoadScene("LevelComplete");
        }

        if (this.currentHealth > 0)
        {
            damaged = true;
            currentHealth -= amount;
            healthSlider.value = currentHealth;

            if (currentHealth <= 0 && !isDead)
            {
                Death();
            }
        }

    }
    
    public void BoostHealth()
    {
        if (this.currentHealth < 100)
        {
            currentHealth += healthBoostAmount;
            healthSlider.value = currentHealth;
        }
    }

    private void Death()
    {
        isDead = true;
    }
}
