using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WildFight : MonoBehaviour
{
    private bool appear = false;
    public float level;
    public float time;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            DecideGender();

        GetType();
    }

    /// <summary>
    /// have a transform start this and once both transfroms 
    /// have touched for >= the time presented in the parameters
    /// begin BeginBattle
    /// </summary>
    /// <param name="time"></param>
    private void BeginBattle(float time)
    {


    }
    

    private void GetType()
    {
        var getType = new Type();

        getType = (Type)Random.Range(0, 12);

        Debug.Log("the type is:" + getType.ToString());
    }


    void DecideGender()
    {
        var getGender = new Gender();
        getGender = (Gender)Random.Range(0, 2);


        if (getGender == Gender.Male)
        {
            var boycube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            var color = new Color(0, 0, 255);
            boycube.GetComponent<Renderer>().material.color = color;
            Instantiate<GameObject>(boycube, new Vector3(0, 1.5f, 0), gameObject.transform.rotation, gameObject.transform);
            Debug.Log("its a boy");
        }

        if (getGender == Gender.Female)
        {
            var girlcube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            var color = new Color(255, 0, 255);
            girlcube.GetComponent<Renderer>().material.color = color;
            Instantiate<GameObject>(girlcube, new Vector3(0, 1.5f, 0), gameObject.transform.rotation, gameObject.transform);
            Debug.Log("its a girl");
        }
    }

}
