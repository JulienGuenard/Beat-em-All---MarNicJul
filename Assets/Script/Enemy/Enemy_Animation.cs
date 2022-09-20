using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Animation : Enemy_Heritage
{
    private void Update()
    {
        Order();
        MoveAnimation();
        Flip();
    }

    void Order()
    {
        spriteR.sortingOrder = Mathf.FloorToInt(transform.position.y);
    }

    void MoveAnimation()
    {
        if (rb.velocity.x != 0 && rb.velocity.y != 0) animator.SetBool("isMoving", true);
        else animator.SetBool("isMoving", false);
    }

    void Flip()
    {
        if (rb.velocity.x > 0.5f) spriteR.flipX = false;
        if (rb.velocity.x < -0.5f) spriteR.flipX = true;
    }
}
