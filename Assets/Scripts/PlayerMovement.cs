using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    CharacterController charController;         //Storing Character Controller Attached to the object

    [SerializeField] float jumpSpeed = 20.0f;   //Variables associated with jumping
    [SerializeField] float gravity = 1.0f;
    float yVelocity = 0.0f;

    [SerializeField] float moveSpeed = 5.0f;    //h and v will be used to capture input
    public float h;
    public float v;

	// Use this for initialization
	void Start () {
        charController = GetComponent<CharacterController>();   //Grabbing the Character Controller using GetComponent
	}

    
	
	// Update is called once per frame
	void Update () {
        h = Input.GetAxis("Horizontal"); //First we get the value of h and v and save them, we do this using the Input class. This contains MooICT Damaging, Shooting and Interaction in Unityhelpful utilities for getting input such as GetAxis and GetButton.In this case Axis and Button are predefined by Unity
        
                v = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(h, 0, v);
        Vector3 velocity = direction * moveSpeed;

        if (charController.isGrounded){
            if (Input.GetButtonDown("Jump"))
            {
                yVelocity = jumpSpeed;
            }
        } else{
            yVelocity -= gravity;
        }
        velocity.y = yVelocity;

        velocity = transform.TransformDirection(velocity);

        charController.Move(velocity * Time.deltaTime);
	}
}
