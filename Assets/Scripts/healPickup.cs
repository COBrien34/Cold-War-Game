using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healPickup : MonoBehaviour {

   
    void OnTriggerEnter(Collider collider) {
        print("pick up");
        if (collider.CompareTag("Player"))
        {


            Health health = collider.GetComponent<Health>();
            if (health != null)
            {
                health.Damage(-20);
            }

      
        }

        Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
