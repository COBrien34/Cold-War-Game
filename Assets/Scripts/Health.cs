using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    [SerializeField] int maximumHealth = 100; //Defining Varibles
    int currentHealth = 0;
   


	// Use this for initialization
	void Start () {
        currentHealth = maximumHealth;
	}
	
    public bool IsDead { get { return currentHealth <= 0; } } //Checking what health the player is on

    public int getHealth()
    {
        return currentHealth; //Returning Current Health
    }

    public int getMaxHealth()
    {
        return maximumHealth; //Returning Max Health
    }

    public void Damage(int damageValue)
    {
        currentHealth -= damageValue;

        if (currentHealth <= 0){
            if (!(gameObject.tag == "Player")) //If the player's health drops below 100, the player will be destroyed
            Destroy(gameObject);
        }
    }

    
    // Update is called once per frame
    void Update () {
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("Win Level"); //This function loads up the win level scene 
        }
	}
}
