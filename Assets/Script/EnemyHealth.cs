using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Enemy_Heritage
{
    public int maxHealth = 100;
    public int currentHealth;

    new void Awake()
    {
        base.Awake();
        currentHealth = maxHealth; 
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }

    }

    private void Die()
    {
        enemy_Loot.Loot();
        enemy_Animation.AnimationDead();
    }
}
