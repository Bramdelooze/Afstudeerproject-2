using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Movement
{
    public float VerticalMovementSpeed = 5;

    public static event Action OnPlayerFlying;

    private void Update()
    {
        if(OnPlayerFlying != null)
        {
            OnPlayerFlying();
        }
        GetInput();
    }

    void FixedUpdate()
    {
        Move();
        ConstrainMovement();
    }

    void GetInput()
    {
        base.verticalMovement = Input.GetAxis("Vertical") * VerticalMovementSpeed;    
    }

    void ConstrainMovement()
    {
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4.5f, 4.5f));
    }
}