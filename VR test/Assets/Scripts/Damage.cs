using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour {

    public bool kill = true;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnCollisionEnter(Collision other)
    {
        if((other.gameObject.CompareTag("Player")) && (kill == true))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
