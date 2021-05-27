using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStates : MonoBehaviour
{
    public float movementSpeed;
    private FocusBar focusBar;
    private bool enemyIsInRange = false;
    private GameObject damagedEnemy;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("IsAttacking", true);
            if (enemyIsInRange)
            {
                KillEnemy();
                focusBar.MoveSlider(20);
            }
        }
    }

    private void StopAttack()
    {
        animator.SetBool("IsAttacking", false);
    }

    private void KillEnemy()
    {
        if(damagedEnemy != null)
            Destroy(damagedEnemy);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsCollisionEnemy(collision))
            enemyIsInRange = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "UFO" && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(IsCollisionEnemy(collision))
            enemyIsInRange = false;
    }

    private bool IsCollisionEnemy(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            damagedEnemy = collision.gameObject;
            return true;
        }
        else return false;
    }

    private void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;

        transform.Translate(horizontalInput, 0, 0);
    }
}
