using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject wall;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
	
	public float xSize;
	public float ySize;
    public GameManager gameManager;

    private float timeBtwSpawn;
    
	// Use this for initialization
	void Start () {
		timeBtwSpawn = startTimeBtwSpawn;
	}
	
	// Update is called once per frame
	void Update () {
	if(gameManager.levelStared){
			if(timeBtwSpawn <= 0) {
				Spawn();
				timeBtwSpawn = startTimeBtwSpawn;
				if (startTimeBtwSpawn > minTime) {
					startTimeBtwSpawn -= decreaseTime;
				}
			} else {
				timeBtwSpawn -= Time.deltaTime;
			}
		}
	}
	
	void OnDrawGizmos(){
		Gizmos.color = Color.green;
        Gizmos.DrawCube(transform.position, new Vector3(xSize, ySize, 1));
	}

    void Spawn() {
        int spawnPointX = 9;
        int spawnPointY = Random.Range(-4, 4);
        Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, 0);
        Instantiate(wall, spawnPosition, Quaternion.identity, this.transform);
    }
}
