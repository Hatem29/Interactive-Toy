using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ahmad : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float rotationSpeed;
    private Vector3 direction;
    private Quaternion lookDirection;
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10;

        Vector3 InUnityPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        direction = (InUnityPosition - transform.position).normalized * -1;
        lookDirection = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookDirection, rotationSpeed * Time.deltaTime);

        if (Input.GetMouseButton(0))
        {
            transform.position = Vector3.Lerp(transform.position, InUnityPosition, speed * Time.deltaTime);
        }


    }

}
