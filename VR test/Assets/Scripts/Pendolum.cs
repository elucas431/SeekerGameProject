using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendolum : MonoBehaviour {

    Quaternion _start, _end;

    [SerializeField, Range(0.0f, 360f)]
    private float angle = 90.0f;

    [SerializeField, Range(0.0f, 5.0f)]
    private float speed = 2.0f;

    [SerializeField, Range(0.0f, 10.0f)]
    private float startime = 0.0f;


    // Use this for initialization
    void Start () {

        _start = PendulumRotation(angle);
        _end = PendulumRotation(-angle);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        startime += Time.deltaTime;
        transform.rotation = Quaternion.Lerp(_start, _end, (Mathf.Sin(startime * speed + Mathf.PI / 2) + 1.0f) / 2.0f);

        //transform.rotation = Quaternion.Lerp(_start, _end, Mathf.Sin(startime * speed + Mathf.PI / 2) + 1.0f) / 2.0f);
    }

    private void ResetTimer()
    {
        startime = 0.0f;
    }


    Quaternion PendulumRotation(float angle)
    {
        var pendulumRoation = transform.rotation;
        var angleZ = pendulumRoation.eulerAngles.z + angle;

        if (angleZ > 100)
        {
            angleZ -= 360;
        }
        else if(angleZ < -100)
        {
            angleZ += 360;
        }

        pendulumRoation.eulerAngles = new Vector3(pendulumRoation.eulerAngles.x, pendulumRoation.eulerAngles.y, angleZ);
        return pendulumRoation;

    }
}
