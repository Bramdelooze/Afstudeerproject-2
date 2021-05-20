using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //private Rigidbody myRigidBody;
    public float VerticalMovementSpeed = 5;

    public static event Action OnPlayerFlying;
    /*
    private void OnEnable()
    {
        FocusBar.OnFocusTooLow += FocusTooLow;
        FocusBar.OnFocusNormal += FocusNormal;
    }
    private void OnDisable()
    {
        FocusBar.OnFocusTooLow -= FocusTooLow;
        FocusBar.OnFocusNormal -= FocusNormal;
    }

    void FocusTooLow()
    {
        ChangeMovementSpeed(VerticalMovementSpeed / 5);
    }

    void FocusNormal()
    {
        ChangeMovementSpeed(VerticalMovementSpeed);
    }
    */

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    private void Update()
    {
        if(OnPlayerFlying != null)
        {
            OnPlayerFlying();
        }
    }

    //Moves the player on the y-axis but within the borders of the camera
    private void Move()
    {
        float verticalInput = Input.GetAxis("Vertical") * VerticalMovementSpeed * Time.deltaTime;

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4.5f, 4.5f), transform.position.z);

        transform.Translate(0, verticalInput, 0);
    }

    public void ChangeMovementSpeed(float speed)
    {
        VerticalMovementSpeed = speed;
    }
}