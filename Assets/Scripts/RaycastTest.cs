using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    RaycastHit hitInfo;

    // Use this for initialization
    void Start()
    {

    }

    void FixedUpdate()
    {
        RaycastHit hit;
        Vector3 up = transform.TransformDirection(Vector3.up);


        if (Physics.Raycast(transform.position, -Vector3.up, out hit, 100.0f))
            Debug.DrawLine(transform.position, hitInfo.point, Color.red, 5.0f);
            print("Found an object - distance: " + hit.distance);

    }
}