using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Animation : Enemy_Heritage
{
    public AnimationState animationState = AnimationState.isIdle;

    private void Update()
    {
        AnimationMove();
        Flip();
    }

    void AnimationIdle()
    {
        animationState = AnimationState.isIdle;
    }

    void AnimationMove()
    {
        if (animationState == AnimationState.isAttacking) return;

        if (rb.velocity.x != 0 && rb.velocity.y != 0)
        {
            animationState = AnimationState.isMoving;
            animator.SetBool("isMoving", true);
        }else
        {
            animationState = AnimationState.isIdle;
            animator.SetBool("isMoving", false);
        }
        
    }

    public void AnimationAttackStop()
    {
        animator.SetBool("isAttacking", false);
        AnimationIdle();
    }

    public void AnimationAttack()
    {
        animator.SetBool("isAttacking", true);

        if (animationState == AnimationState.isAttacking) return;

     //   animationState = AnimationState.isAttacking;

    }

    void AnimationJump()
    {
    //    animationState = AnimationState.isJumping;
     //   animator.SetBool("isJumping", false);
    }

    public void AnimationDead()
    {
        animationState = AnimationState.isDead;
        animator.SetBool("isDead", true);
    }

    public void Destroy()
    {
        Destroy(this.gameObject);
    }

    void Flip()
    {
        if (rb.velocity.x > 0.1f) transform.rotation = Quaternion.Euler(0,0,0);
        if (rb.velocity.x < -0.1f) transform.rotation = Quaternion.Euler(0, 180, 0);
    }

    public void FlipAttack()
    {
        if (player.transform.position.x > transform.position.x) transform.rotation = Quaternion.Euler(0, 0, 0);
        if (player.transform.position.x < transform.position.x) transform.rotation = Quaternion.Euler(0, 180, 0);
    }
}
