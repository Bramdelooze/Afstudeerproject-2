using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStates : MonoBehaviour
{
    public float movementSpeed;
    private FocusBar focusBar;

    private void Awake()
    {
        focusBar = FindObjectOfType<FocusBar>();
    }

    private void Update()
    {
        Attack();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //&& the sword hits an enemy with the animation
        {
            focusBar.MoveSlider(10);
        }
    }

    private void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;

        transform.Translate(horizontalInput, 0, 0);
    }
}
