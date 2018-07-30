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
　　　Transform GetClosestWall (Transform[] walls)
        {
            Transform closestTarget = null;
            float closestDistanceSqr = Mathf.Infinity;
            Vector3 currentPosition = transform.position;
            foreach(Transform potentialTarget in walls)
            {
                Vector3 directionToTarget = potentialTarget.position - currentPosition;
                float dSqrToTarget = directionToTarget.sqrMagnitude;
                if(dSqrToTarget < closestDistanceSqr)
                {
                    closestDistanceSqr = dSqrToTarget;
                    closestTarget = potentialTarget;
                }
            }
            return closestTarget;
        }

}
