using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crazy : MonoBehaviour
{

    float xNew;
    float yNew;
    float zNew;

    [SerializeField]
    float xSpeed;
    [SerializeField]
    float ySpeed;
    [SerializeField]
    float zSpeed;

    void Update()
    {
        float xNew = Mathf.PingPong(Time.time * xSpeed, 10) - 5;
        float yNew = Mathf.PingPong(Time.time * ySpeed, 4) + 2.5f;
        float zNew = Mathf.PingPong(Time.time * zSpeed, 20) - 10;
        transform.position = new Vector3(xNew, yNew, zNew);
    }
}
