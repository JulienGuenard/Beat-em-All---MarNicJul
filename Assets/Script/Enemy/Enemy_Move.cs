using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class Enemy_Move : Enemy_Heritage
{
    public float speed;
    public float randomMoveDelay;
    public GameObject randomPoint;

    float x = 0;
    float y = 0;

    GameObject randomPointCurrent;
    bool canMoveRandomly = true;

    void Update()
    {
        if (enemy_Animation.animationState == AnimationState.isAttacking)
        {
            rb.velocity = Vector3.zero;
            return;
        }
        
        if (player == null) player = GameObject.FindGameObjectWithTag("Player");
        if (player == null) return;

        if (enemy_IA.enemyIA_MoveState == EnemyIA_MoveState.FollowPlayer)   FollowPlayer();

        if (randomPointCurrent == null && randomPoint != null) randomPointCurrent = Instantiate(randomPoint);
        if (randomPointCurrent == null) return;

        if (enemy_IA.enemyIA_MoveState == EnemyIA_MoveState.MoveRandomly)   MoveRandomly();
        if (enemy_IA.enemyIA_MoveState == EnemyIA_MoveState.MoveToItem)     MoveToItem();
        if (enemy_IA.enemyIA_MoveState == EnemyIA_MoveState.Flee)           Flee();
    }

    void FollowPlayer()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;

        rb.velocity = direction * speed;
    }

    void MoveRandomly()
    {
        rb.velocity = Vector3.zero;

        if (canMoveRandomly)
        {
            Vector3 randomPointPos = new Vector3(Random.Range(-2f, 2f), Random.Range(-0.5f, -1), 0);
            randomPointCurrent.transform.position = randomPointPos;
            canMoveRandomly = false;
            StartCoroutine(MoveRandomlyDelay());
        }

        Vector3 direction = (randomPointCurrent.transform.position - transform.position).normalized;

        if (randomPointCurrent.transform.position.x < transform.position.x + 0.1f
        && randomPointCurrent.transform.position.x > transform.position.x - 0.1f
        && randomPointCurrent.transform.position.y < transform.position.y + 0.1f
        && randomPointCurrent.transform.position.y > transform.position.y - 0.1f) return;

        rb.velocity = direction * speed;

        
    }

    IEnumerator MoveRandomlyDelay()
    {
        yield return new WaitForSeconds(randomMoveDelay);
        canMoveRandomly = true;
    }

    void MoveToItem()
    {

    }

    void Flee()
    {

    }
}
