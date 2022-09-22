using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : Enemy_Heritage
{
    public float damage;

    public void Attack()
    {
        enemy_Animation.AnimationAttack();
        enemy_Animation.FlipAttack();
    }

    public void EnableAttackHit()
    {
        attackCollider.enabled = true;
    }

    public void DisableAttackHit()
    {
        attackCollider.enabled = false;
    }
}
