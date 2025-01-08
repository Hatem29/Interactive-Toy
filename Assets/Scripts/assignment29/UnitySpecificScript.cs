using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UnitySpecificScript : MonoBehaviour
{
    GameObject target;

    void Start()
    {
        print("Game started!");

        target = GameObject.Find("TargetObject");
        if (target != null)
        {
            print($"Found object by name: {target.name}");
        }
        else
            print("No TargetObject found.");

        GameObject joker = GameObject.FindGameObjectWithTag("Joker");
        if (joker != null)
            print($"Found object by tag: {joker.name}");
        else
            print("No Joker object found.");

        Light light = GameObject.FindObjectOfType<Light>();
        if (light != null)
            print($"Found object by type: {light.name}");
        else
            print("No Light object found.");
    }

    private void OnEnable()
    {
        print("GameObject Enabled!");
    }

    private void OnDisable()
    {
        print("GameObject Disabled!");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            target.SetActive(false);
            print("TargetObject deactivated!");
        }
    }
}
