using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lavacollision : MonoBehaviour {

    bool isDead = false; // Placement for global bool 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "player")
        {
            isDead = true; 
        }
    }
}
