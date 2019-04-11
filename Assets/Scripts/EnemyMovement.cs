using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    Transform playerModel;
    CharacterController controller;

    Vector3 velocity;

    [SerializeField]
    float moveSpeed = 5.0f;
    public float h;
    public float v;

    // Use this for initialization
    void Start () {
        GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
        playerModel = playerGameObject.transform;
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = playerModel.position - transform.position;

        velocity.x = Mathf.Clamp(direction.x, -1, 1);
        velocity.z = Mathf.Clamp(direction.z, -1, 1);
        velocity.y = -1;

        controller.Move(direction * Time.deltaTime);
	}
}
