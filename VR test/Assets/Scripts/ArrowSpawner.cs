using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour {

    public GameObject arrowPrefab;
    public float startTime, spawnDelay;

	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("SpawnObject", startTime, spawnDelay);
	}
	
	// Update is called once per frame
	public void SpawnObject ()
    {
        Instantiate(arrowPrefab, transform.position, transform.rotation);
	}
}
