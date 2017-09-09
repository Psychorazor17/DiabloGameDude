using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAfterDelay : MonoBehaviour {


    public float spawnDelay = 1.0f;
    public GameObject objectToSpawn;


	// Use this for initialization
	void Start ()

    {
        Invoke("Spawn", spawnDelay);
        
	}
	
	void Spawn()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
        Invoke("Spawn", spawnDelay);
    }
	
}
