using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaFloorMovement1 : MonoBehaviour {


    public Vector3 startPosition, endPosition;
    public float speed, pauseTime, startTime;
    private bool direction = false, finish = false;
    private float stopTime;
    private float timer;
	// Use this for initialization
	void Start () {
        timer = 0;
        startTime += pauseTime;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if((transform.position == endPosition) && (!finish))
        {
            direction = true;
            stopTime = timer + pauseTime;
            finish = true;
        }
        if ((transform.position == startPosition) && (!finish))
        {
            direction = false;
            stopTime = timer + pauseTime;
            finish = true;
        }

        if(direction && (timer > stopTime) && (timer > startTime))
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition, speed);
            finish = false;
        }
        else if ((timer > stopTime) && (timer > startTime))
        {
            transform.position = Vector3.MoveTowards(transform.position, endPosition, speed);
            finish = false;
        }
    }
    /*
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.transform.parent = this.transform;
        }
    }*/
}
