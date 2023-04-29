using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChebuMove : MonoBehaviour
{
    private void Start()
    {
        transform.position = new Vector3(0f, -1f, 0);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.A))
        {
            Quaternion rot = transform.rotation;
            rot.y = 0;
            transform.rotation = rot;
        }
        else if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.D))
        {
            Quaternion rot = transform.rotation;
            rot.y = 180;
            transform.rotation = rot;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position = new Vector3(-1.7f, -1f, 0);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(-3.3f, -1f, 0);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position = new Vector3(1.7f, -1f, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(3.3f, -1f, 0);
        }
    }
}
