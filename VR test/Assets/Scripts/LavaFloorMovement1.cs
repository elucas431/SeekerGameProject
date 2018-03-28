using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaFloorMovement1 : MonoBehaviour {


    public Vector3 startPosition, endPosition;
    public float speed, pauseTime, startTime;
    private bool direction = false, finish = false;
    private float stopTime;

	// Use this for initialization
	void Start () {

        startTime += pauseTime;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        if((transform.position == endPosition) && (!finish))
        {
            direction = true;
            stopTime = Time.time + pauseTime;
            finish = true;
        }
        if ((transform.position == startPosition) && (!finish))
        {
            direction = false;
            stopTime = Time.time + pauseTime;
            finish = true;
        }

        if(direction && (Time.time > stopTime) && (Time.time > startTime))
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition, speed);
            finish = false;
        }
        else if ((Time.time > stopTime) && (Time.time > startTime))
        {
            transform.position = Vector3.MoveTowards(transform.position, endPosition, speed);
            finish = false;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.transform.parent = this.transform;
        }
    }
}
