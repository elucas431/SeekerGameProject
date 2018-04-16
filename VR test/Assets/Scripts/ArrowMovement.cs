using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour {

    public float speed = 1;
    private Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        rb.AddForce(transform.forward * speed);
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
