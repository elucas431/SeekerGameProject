﻿// Written by Matthew Bohr

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relic : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnGrab()
    {
        gameObject.SetActive(false);
        //TODO: Send this to the door somehow
    }
}
