using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

    public float time = 5f;
	
	void Update () {
        time -= Time.deltaTime;
        if(time <= 0) {
            Destroy(gameObject);
        }
	}
}
