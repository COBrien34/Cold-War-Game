using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    float nextTimeAttackIsAllowed = -1.0f;

    [SerializeField]
    float attackDelay = 1.0f; //Setting up a attack delay modifier in the inspector

    [SerializeField]
    int damageDealt = 5; //Setting up a damage modifier in the inspector


    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Time.time >= nextTimeAttackIsAllowed)
        {
            Health playerHealth = other.GetComponent<Health>(); //This function is when the player collides with the enemies collider it will reduce the health of player to 0 instantly
            playerHealth.Damage(damageDealt);
            nextTimeAttackIsAllowed = Time.time + attackDelay;
            gameManager.playerDead(); //Contacting the game manager as the player if the player equals dead
        }
    }
}

    
