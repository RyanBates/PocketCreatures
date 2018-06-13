using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
    public Rect fpsRect = new Rect(5, 5, 100, 100);

    private float FPS;
    GUIStyle style;

    private void Start()
    {
        style = new GUIStyle();
        style.fontSize = 15;
    }

    private void OnGUI()
    {
        FPS = 1 / Time.deltaTime;

        GUI.Label(fpsRect, "FPS:" + string.Format("{0:0}", FPS), style);
    }
}
