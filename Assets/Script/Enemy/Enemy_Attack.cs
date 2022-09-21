using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : Enemy_Heritage
{
    public void Attack()
    {
        enemy_Animation.AnimationAttack();
        enemy_Animation.FlipAttack();
    }
}
