using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_IA : Enemy_Heritage
{
    public EnemyIA_Behaviour enemyIA_Behaviour;
    public EnemyIA_MoveState enemyIA_MoveState;
    public EnemyIA_NextAttack enemyIA_NextAttack;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            enemy_Attack.Attack();
        }
    }
}
