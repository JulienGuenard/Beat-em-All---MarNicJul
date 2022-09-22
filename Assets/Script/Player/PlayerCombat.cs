using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    private Animator animator;

    public AttackCollision attackCollision;

    private EnemyHealth enemyHealth;

    public int attackDamage = 20;
    

    

    
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();

    }

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();

        }


    }

    private void Attack()
    {
        
        //play attack animation
        animator.SetTrigger("Attack1"); // activate trigger in animator

        // Detect enemies in range of attack
        if (attackCollision._getsPunched == true)

        // Inflict damage on enemies
        {
                        
            foreach (GameObject enemy in attackCollision.enemyList) // goes through the list of enemies in attack range and inflicts damage on them
            {
                enemyHealth = enemy.GetComponentInParent<EnemyHealth>();
                enemyHealth.TakeDamage(attackDamage);
                Debug.Log(enemyHealth.currentHealth);

            }            
        }

        else

        { return; }


    }

    
}
