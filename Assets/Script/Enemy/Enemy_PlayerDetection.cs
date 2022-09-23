using UnityEngine;

public class Enemy_PlayerDetection : MonoBehaviour
{
    Enemy_IA enemy_IA;

    private void Awake()
    {
        enemy_IA = GetComponentInParent<Enemy_IA>();
    }

    private void Update()
    {
        if (enemy_IA.enemyIA_MoveState == EnemyIA_MoveState.FollowPlayer) Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            enemy_IA.enemyIA_MoveState = EnemyIA_MoveState.FollowPlayer;
        }
    }
}
