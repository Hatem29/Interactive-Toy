using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class ClownHat : MonoBehaviour
{
    double warningTime;
    double timer;
    double endTimer;
    bool end;

    public GameObject light;
    public GameObject angryClown;
    public GameObject clown;

    private void Start()
    {
        warningTime = 2;
        timer = warningTime;
        endTimer = 5;
        end = false;

        //light = GetComponent<GameObject>();
        //angryClown = GetComponent<GameObject>();
        //clown = GetComponent<GameObject>();
    }

    private void OnMouseOver()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = warningTime;
            Debug.LogWarning("Stop! Don't dare touch the hat!");
        }
    }

    private void OnMouseDown()
    {
        Debug.LogWarning("YOU TOUCHED MY HAT!!!!!!!!");
        end = true;

        light.SetActive(false);
        clown.SetActive(false);
        angryClown.SetActive(true);

    }

    private void Update()
    {
        if (end)
        { 
            endTimer -= Time.deltaTime;
            if (endTimer <= 0)
            {
                Application.Quit();
            }
        }
    }
}
