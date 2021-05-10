﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleyerMovement : MonoBehaviour
{
    //private Rigidbody myRigidBody;
    public float movementSpeed = 5;

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        transform.position = transform.position;
    }

    private void Move()
    {
        float verticalInput = Input.GetAxis("Vertical") * movementSpeed;
        float horizontalInput = Input.GetAxis("Horizontal") * movementSpeed;
        verticalInput *= Time.deltaTime;
        horizontalInput *= Time.deltaTime;

        transform.Translate(horizontalInput, 0, verticalInput);
    }
}
