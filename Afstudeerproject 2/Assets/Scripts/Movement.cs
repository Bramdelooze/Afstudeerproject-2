using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float horizontalMovement;
    public float verticalMovement;
    // Start is called before the first frame update

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(horizontalMovement, verticalMovement, 0);
    }
}
