using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PortalScript : MonoBehaviour
{
    public GameObject winScreen; //Defining variables

      void Start()
    {
        winScreen.SetActive(false); //Turn the pop-up invisble in the scene

    }



    void OnTriggerEnter(Collider collider) //Setting the colliders to trigger to on enter
    {
        print("Portal"); //When the player enters the trigger, print "Portal"
        if (collider.CompareTag("Player"))//If the object inside the trigger matches with the players tag
        {
            winScreen.SetActive(true);//Turn the pop-up visble in the scene
        }

    }
}
