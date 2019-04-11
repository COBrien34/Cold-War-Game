using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PickupPanelScript : MonoBehaviour
{
    public GameObject pickupPanel;
    public GameObject briefcase;
    public GameObject Portal;

    void Start()
    {

    }

    void Update()
    {

    }

 
    void OnTriggerEnter(Collider collider)
    {
        print("Briefcase");
        if (collider.CompareTag("Player"))
        {
            pickupPanel.SetActive(true);
            Destroy(this.gameObject, .1f);
            Portal.SetActive(true);
        }
    }
}
