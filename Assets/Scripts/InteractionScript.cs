using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour {

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    } 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Ray mouseRay = GetComponentInChildren<Camera>().ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hitInfo;

            if (Physics.Raycast(mouseRay, out hitInfo, 100))
            {
                print(hitInfo.transform.name);
                Debug.DrawRay(transform.position, hitInfo.point, Color.red, 5.0f);
                DoorOpenScript Pole = hitInfo.transform.GetComponent<DoorOpenScript>();
                if (!Pole)
                {
                    Pole.enabled = true;

                }

            }

        }

    }
}