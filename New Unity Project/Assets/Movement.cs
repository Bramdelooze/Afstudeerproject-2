using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    protected float horizontalMovement;
    protected float verticalMovement;

    protected void Move()
    {
        transform.Translate(horizontalMovement, verticalMovement, 0);
    }
}
