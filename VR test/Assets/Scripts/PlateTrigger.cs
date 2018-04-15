using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateTrigger : MonoBehaviour {

    public GameObject arrow;
    public Transform whereArrowIsFiredFrom;

    void OnTriggerEnter(Collider collide)
    {
        if (collide.transform.tag == "Player")
            FireArrow();
    }

    void FireArrow()
    {
        Instantiate(arrow, whereArrowIsFiredFrom.position, Quaternion.identity);
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FireArrow();
        }
    }
}
