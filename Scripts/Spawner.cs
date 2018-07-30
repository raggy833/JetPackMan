using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject wall;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    private float timeBtwSpawn;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(timeBtwSpawn <= 0) {
            Instantiate(wall, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > minTime) {
                startTimeBtwSpawn -= decreaseTime;
            }

        } else {
            timeBtwSpawn -= Time.deltaTime;
        }
	}

    //void Spawn() {
    //    int spawnPointX = Random.Range(-450, 450);
    //    int spawnPointY = Random.Range(-360, 350);
    //    Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, 0);
    //    Instantiate(enemy, spawnPosition, Quaternion.identity);
    //}
}
