using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : Movement
{
    [SerializeField] private float HorizontalMovementSpeed = .1f;

    void Awake()
    {
        SetMovementSpeed(HorizontalMovementSpeed);
    }
    void SetMovementSpeed(float speed)
    {
        base.horizontalMovement = speed;
    }

    void FixedUpdate()
    {
        Move();
    }
}
