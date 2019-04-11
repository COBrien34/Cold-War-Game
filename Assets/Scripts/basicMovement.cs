using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicMovement : MonoBehaviour {

    CharacterController varController; //Defining varibles 
    [SerializeField] float jumpSpeed = 20.0f;              
    [SerializeField] float gravity = 1.0f;
    float yVelocity = 0.0f;
    [SerializeField] float moveSpeed = 5.0f;
    public GameObject pickupPanel;

    void Start () {
        varController = GetComponent<CharacterController>();
        pickupPanel.SetActive(false); //On start set the panel to false which is deactivated so it can be activated later in the level
    }
	
	// Update is called once per frame
	void Update ()
    {
        float X = Input.GetAxis("JoystickX"); //Setup for right thumbstick
        Vector3 rot = transform.localEulerAngles;
        rot.y += X * 5;
        transform.localEulerAngles = rot;

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(h, 0, v);
        Vector3 velocity = direction * moveSpeed;
        if (varController.isGrounded) //Groundcheck again
        {
            if (Input.GetButtonDown("Jump"))
            {
                yVelocity = jumpSpeed;
            }
        }
        else
        {
            yVelocity -= gravity;
        }
        velocity.y = yVelocity;
        velocity = transform.TransformDirection(velocity);
        varController.Move(velocity * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Escape)) //If the player presses the escape key then it will deactivate a panel that is active
        {
            pickupPanel.SetActive(false);
        }
    }
}
