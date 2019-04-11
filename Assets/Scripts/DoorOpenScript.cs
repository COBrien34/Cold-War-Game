using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenScript : MonoBehaviour {

    Animator anim;

    private bool Open;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        Open = false;
	}

    // Update is called once per frame
    void Update() {

        anim.SetBool("Open", Open);

    }
        
    private void OnEnable()
    {
        Open = true;
    }

    private void OnDisable()
    {
        Open = false;
    }
}

