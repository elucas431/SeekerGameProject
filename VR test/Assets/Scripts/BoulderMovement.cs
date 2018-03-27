using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderMovement : MonoBehaviour {

    public Rigidbody rb;
    public GameObject trigger, speedTrigger;
    public bool force = false, active = false;
    public float speed = 0f;

    // Use this for initialization
    void Start()
    {
        transform.rotation = Quaternion.Euler(0f, 270f, 0f);
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezePositionZ
            | RigidbodyConstraints.FreezePositionY
            | RigidbodyConstraints.FreezeRotationZ
            | RigidbodyConstraints.FreezeRotationY;
    }
	
	// Update is called once per frame
	void Update ()
    {
        active = trigger.GetComponent<ActivateBoulder>().activate;
        //if (Input.GetKeyDown(KeyCode.Space)) { 
		if (active == true)
        {
            rb.useGravity = true;
            rb.constraints = RigidbodyConstraints.None;
           // rb.constraints = RigidbodyConstraints.FreezeRotationY
           // | RigidbodyConstraints.FreezeRotationZ;
        }
	}

    public void OnCollisionEnter(Collision other)
    {
        GameObject floor = other.gameObject;
        if(floor == speedTrigger)
        {
            transform.rotation = Quaternion.Euler(0f, 270f, 0f);
            force = true;
        }
    }

    void FixedUpdate()
    {
        if (force == true)
        {
            Vector3 exl = new Vector3(-speed, 0f, 0f);
            rb.AddForce(exl, ForceMode.Acceleration);
        }
    }
}
