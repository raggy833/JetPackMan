using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float upPower = 5f;
    public Transform[] wallClones;
    List<Transform> wallTest = new List<Transform>();

    private Rigidbody rb;

    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();

    }

    void Update() {
        GameObject[] allWalls = GameObject.FindGameObjectsWithTag("Wall");
        for (int i = 0; i < allWalls.Length; i++) {
            //Debug.Log(allWalls[i].transform.position);
            wallTest.Add(allWalls[i].transform);
            //wallClones[i] = allWalls[i].transform;
            //GetClosestWall(wallTest);
        }
    }

    // Update is called once per frame
    void FixedUpdate() {
        
        if (Input.GetKey(KeyCode.UpArrow)) {
            rb.velocity = new Vector3(0, upPower, 0);
        }
    }


    Transform GetClosestWall(Transform[] walls) {
        Transform closestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = transform.position;
        foreach (Transform potentialTarget in walls) {
            Vector3 directionToTarget = potentialTarget.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if (dSqrToTarget < closestDistanceSqr) {
                closestDistanceSqr = dSqrToTarget;
                closestTarget = potentialTarget;
            }
        }
        return closestTarget;
    }
}
