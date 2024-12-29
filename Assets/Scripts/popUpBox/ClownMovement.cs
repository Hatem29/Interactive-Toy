using popUpBox;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClownMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotationSpeed;
    private Vector3 direction;
    private Quaternion lookDirection;
    private Rigidbody rb;
    private float stoppingDistance;

    private void Start()
    {
        speed = 15f;
        rotationSpeed = 15f;
        rb = GetComponent<Rigidbody>();
        stoppingDistance = 0.5f;
    }

    void Update()
    {
        if (rb == null) return;

        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 15;

        Vector3 InUnityPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        direction = (InUnityPosition - transform.position).normalized * -1;

        lookDirection = Quaternion.LookRotation(direction);
        rb.MoveRotation(Quaternion.Slerp(transform.rotation, lookDirection, rotationSpeed * Time.deltaTime));
        
        float distance = Vector3.Distance(rb.position, InUnityPosition);
        if (distance > stoppingDistance)
        {
            if (Input.GetMouseButton(0) && transform.CompareTag(Utility.HappyClown))
            {
                rb.velocity = direction * speed * -1;
            }
            else if (Input.GetMouseButton(1) && transform.CompareTag(Utility.BadClown))
            {
                rb.velocity = direction * speed * -1;
            }
            else
            {
                rb.velocity = Vector3.zero;
            }
        }
        else
        {
            rb.velocity = Vector3.zero;
        }

    }
}
