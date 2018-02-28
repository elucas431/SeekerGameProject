using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBoulder : MonoBehaviour {

    public bool activate;

	// Use this for initialization
	void Start ()
    {
        activate = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            activate = true;
        }
    }
}
