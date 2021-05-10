using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleyerMovement : MonoBehaviour
{
    //private Rigidbody myRigidBody;
    public float movementSpeed = 5;

    // Update is called once per frame
    void FixedUpdate()
    {
        float verticalInput = Input.GetAxis("Vertical") * movementSpeed;
        float horizontalInput = Input.GetAxis("Horizontal") * movementSpeed;
        verticalInput *= Time.deltaTime;
        horizontalInput *= Time.deltaTime;

        transform.Translate(horizontalInput, 0, verticalInput);
        
        //update the position
        //transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, 0, verticalInput * movementSpeed * Time.deltaTime);// x,y,z
    }
}
