using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private float speed = 1;
    private float maxSpeed = 10;
    
    void Update ()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position -= new Vector3(0, 0, 5) * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            transform.position += new Vector3(0, 0, 5) * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
            transform.position -= new Vector3(5, 0, 0) * Time.deltaTime;

        GetSpeed();
    }

    private void GetSpeed()
    {
        if (speed >= maxSpeed)
            speed = maxSpeed;
    }
}
