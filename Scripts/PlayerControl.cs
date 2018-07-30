using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float upPower = 5f;

    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        MoveForward();
        if (Input.GetKey(KeyCode.UpArrow)) {
            rb.velocity = new Vector3(0, upPower, 0);
        }
	}

    void MoveForward() {
       
    }
}
