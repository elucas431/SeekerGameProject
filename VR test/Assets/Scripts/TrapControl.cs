using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapControl : MonoBehaviour {

    float moveTrap = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && moveTrap < 11.0f)
        {
            moveTrap += 0.2f;
        }

        else if (moveTrap >= 11.0f)
        {
            moveTrap = 10.0f;
        }
        this.transform.Translate(0.0f, 0.0f, moveTrap);

       
	}
}
