using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.CompareTag("Detect"))
        {
            GetComponent<Damage>().kill = false;
        }
        else if(other.gameObject.CompareTag("Shield"))
        {

        }
    }
}
