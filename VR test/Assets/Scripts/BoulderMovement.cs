using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderMovement : MonoBehaviour {

    public Rigidbody rb;
    //public GameObject trigger;
    public bool active = false;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        //active = trigger.GetComponent<ActivateBoulder>().activate;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { 
		//if (active == true)
        //{
            rb.useGravity = true;
        }
	}
}
