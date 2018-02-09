using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float panSpeed = 20f;
    public float panBoarderThickness = 10f;

    // Update is called once per frame
    void Update()
    {

        Vector3 position = transform.position;
        if (Input.GetKey("w"))//|| (Input.mousePosition.y >= (Screen.height - panBoarderThickness)))
        {
            position.z += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("s"))//|| (Input.mousePosition.y <= (Screen.height - panBoarderThickness)))
        {
            position.z -= panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d"))//|| (Input.mousePosition.x >= (Screen.width - panBoarderThickness)))
        {
            position.x += panSpeed * Time.deltaTime;
        }
        if (Input.GetKey("a"))//|| (Input.mousePosition.x <= (Screen.height - panBoarderThickness)))
        {
            position.x -= panSpeed * Time.deltaTime;
        }

        transform.position = position;
    }
}

