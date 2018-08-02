using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float upPower = 5f;
    public Transform[] wallClones;
    public Transform[] testWall;
    public List<Transform> wallTest = new List<Transform>();

    private Rigidbody rb;

    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();

    }

    void Update() {
        GameObject[] allWalls = GameObject.FindGameObjectsWithTag("Wall");
        WallControl[] wallClones = GameObject.FindObjectsOfType<WallControl>();

        foreach (WallControl closestWall in wallClones) {
            Vector3 directionToTarget = closestWall.transform.position - this.transform.position;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            float closestDistanceSqr2 = Mathf.Infinity;
            WallControl closestTarget2 = null;
            if (dSqrToTarget < closestDistanceSqr2) {
                closestDistanceSqr2 = dSqrToTarget;
                closestTarget2 = closestWall;
            }
            Debug.Log(closestWall.transform.position);
        }


        //Debug.Log(allWalls.Length);
        for (int i = 0; i < allWalls.Length; i++) {
            wallTest.Add(allWalls[i].transform);
        }
        for (int i = 0; i < testWall.Length; i++) {
            GetClosestWall(testWall);
            // This shows the closest wall
            Debug.Log("Position is " + GetClosestWall(testWall).position);
        }
    }

    // Update is called once per frame
    void FixedUpdate() {
        if(transform.position.y < 0) {
            rb.velocity = new Vector3(0, upPower, 0);
        }
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
