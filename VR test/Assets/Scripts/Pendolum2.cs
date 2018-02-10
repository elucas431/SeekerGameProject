using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendolum2 : MonoBehaviour
{
    public GameObject trap;
    
    Quaternion _start, _end;

    [SerializeField, Range(0.0f, 360f)]
    private float angle = 45.0f;

    [SerializeField, Range(0.0f, 5.0f)]
    private float speed = 5.0f;

    [SerializeField, Range(0.0f, 10.0f)]
    private float startime = 0.0f;


    // Use this for initialization
    void Start()
    {
        trap.SetActive(false); 
        _start = PendulumRotation(angle);
        _end = PendulumRotation(-angle);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            trap.SetActive(true);
            startime += Time.deltaTime;
            transform.rotation = Quaternion.Lerp(_start, _end, Mathf.Sin(startime * speed + Mathf.PI / 2) + 1.0f);
        }
    }

    
    Quaternion PendulumRotation(float angle)
    {
        var pendulumRoation = transform.rotation;
        var angleZ = pendulumRoation.eulerAngles.z + angle;

        if (angleZ > 100)
        {
            angleZ -= 360;
        }
        else if (angleZ < -100)
        {
            angleZ += 360;
        }

        pendulumRoation.eulerAngles = new Vector3(pendulumRoation.eulerAngles.x, pendulumRoation.eulerAngles.y, angleZ);
        return pendulumRoation;

    }

   
}

