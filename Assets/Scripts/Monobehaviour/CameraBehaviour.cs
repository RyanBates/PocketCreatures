using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// we dont use this. this is for me to improve in other projects outside of this one 
public class CameraBehaviour : MonoBehaviour
{
    public GameObject player;

    public float height = 1, distance;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;  
    }

    void Update ()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + height, player.transform.position.z + distance);

        transform.LookAt(player.transform);

        if (Input.GetKeyDown(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
