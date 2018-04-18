// Written by Matthew Bohr

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relic : MonoBehaviour {
    public int gameState;
    public GameObject Door;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            Door.GetComponent<DoorControl>().numOfRelics++;
        }
    }
}