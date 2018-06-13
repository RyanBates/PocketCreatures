using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrassBehaviour : MonoBehaviour
{
    WildFight wild;
    Creature creature;
    private bool appear = false;
    public int level;

    //public GameObject player;
    public float time;
    public float begin;

    private void Update()
    {
        BeginBattle(time);

        if (appear == true)
            SceneManager.LoadScene("1.Battle");
    }

    private void OnTriggerEnter(Collider other)
    {
        begin = begin++ + Time.deltaTime;
        Debug.Log("im in.");
    }
    private void OnTriggerStay(Collider other)
    {
        begin = begin++ + Time.deltaTime;
    }
    
    private void BeginBattle(float t)
    {
        t = time;

        if (begin >= t)
        {
            GetCreature();
            GetGender();
            begin = 0;
            appear = true;
        }
    }

    public void GetCreature()
    {
        creature = new Creature();

        var getType = new Type();
        getType = (Type)Random.Range(0, 12);

        level = Random.Range(1, 100);
        creature.LVL = level;

        Debug.Log("the type is:" + getType.ToString());
    }


    public void GetGender()
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
