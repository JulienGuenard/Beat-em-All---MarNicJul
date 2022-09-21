using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;


    // Start is called before the first frame update
    void Awake()
    {
        currentHealth = maxHealth; 
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        // Play hurt animation

        if(currentHealth <= 0)
        {
            Die();

        }

    }

    private void Die()
    {
        Debug.Log("Enemy died!");
        
        // Die animation

        // despawn object
    }
}
