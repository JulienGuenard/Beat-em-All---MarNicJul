using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer spriteR;
    public float speed;

    float x = 0;
    float y = 0;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        MoveInput();
        MoveFlip();
        MoveAnimation();
        MoveVelocity();
    }

    void MoveInput()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
    }

    void MoveFlip()
    {
        if (x > 0) spriteR.flipX = false;
        if (x < 0) spriteR.flipX = true;
    }

    void MoveAnimation()
    {
        if (x != 0 || y != 0)
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }

    void MoveVelocity()
    {
        rb.velocity = new Vector3(x, y, 0) * speed * Time.deltaTime;
    }
}
