using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //private Rigidbody myRigidBody;
    public float movementSpeed = 5;

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float verticalInput = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        //float horizontalInput = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4.5f, 4.5f), transform.position.z);

        transform.Translate(0, verticalInput, 0);
    }
}