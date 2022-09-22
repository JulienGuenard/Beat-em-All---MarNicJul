using UnityEngine;

public class Enemy_AttackHit : MonoBehaviour
{
    Enemy_Attack enemy_Attack;

    private void Awake()
    {
        enemy_Attack = GetComponentInParent<Enemy_Attack>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponentInParent<PlayerHealth>().LifeCurrentAdd(enemy_Attack.damage);
        }
    }
}
