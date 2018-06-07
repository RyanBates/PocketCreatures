using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            DecideGender();
    }

    void DecideGender()
    {
        var getGender = new Gender();
        getGender = (Gender)Random.Range(0, 1);


        if (getGender == Gender.Male)
        {
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            var color = new Color(0, 0, 255);
            cube.GetComponent<Renderer>().material.color = color;
            Instantiate<GameObject>(cube, new Vector3(0, 1.5f, 0), gameObject.transform.rotation, gameObject.transform);
        }

        if (getGender == Gender.Female)
        {
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            var color = new Color(255, 192, 203);
            cube.GetComponent<Renderer>().material.color = color;
            Instantiate<GameObject>(cube, new Vector3(0, 1.5f, 0), gameObject.transform.rotation, gameObject.transform);
        }
    }

}
