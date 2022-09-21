using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    private Animator _animator;

    [SerializeField] GameObject _AttackCollider;

    public AttackCollision _attackCollisionScript;

    public EnemyHealth _enemyHealthScript;
    

    

    
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponentInChildren<Animator>();

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
        _animator.SetTrigger("Attack1"); // activate trigger in animator

        // Detect enemies in range of attack
        if(_attackCollisionScript._canBeAttacked == true)
        
        // Inflict damage on enemies
        _enemyHP--;

        if (_enemyHP <= 0)
        {
            Destroy(gameObject);
        }


    }

    
}
