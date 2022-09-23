using System.Collections;
using UnityEngine;

public class Enemy_Jump : Enemy_Heritage
{
    public float delayMin;
    public float delayMax;

    new public void Awake()
    {
        base.Awake();
        StartCoroutine(JumpDelay());
    }

    public void Jump()
    {
        if (enemy_Animation.animationState == AnimationState.isAttacking) return;
        if (enemy_Animation.animationState == AnimationState.isDead) return;
        if (enemy_IA.enemyIA_MoveState != EnemyIA_MoveState.FollowPlayer) return;

        enemy_Animation.AnimationJump();
    }

   IEnumerator JumpDelay()
    {
        float newDelay = Random.Range(delayMin, delayMax);
        yield return new WaitForSeconds(newDelay);
        Jump();
        StartCoroutine(JumpDelay());
    }
}
