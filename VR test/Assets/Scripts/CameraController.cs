using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float panSpeed = 20f;
    public float panBoarderThickness = 10f;
    public Vector2 panLimit;
    public float scrollSpeed = 20f;
    public float minY = 20f;
    public float maxY = 120f;


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

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        position.y -= scroll * scrollSpeed * 100f * Time.deltaTime;
        /* testing branch
        position.x = Mathf.Clamp(position.x, -panLimit.x, panLimit.x);
        position.y = Mathf.Clamp(position.y, minY, maxY);
        position.z = Mathf.Clamp(position.z, -panLimit.y, panLimit.y);
        */
        transform.position = position;
    }
}

