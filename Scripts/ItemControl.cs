using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

	}
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
            Debug.Log("power up");
            Destroy(gameObject);
        }
    }
}
