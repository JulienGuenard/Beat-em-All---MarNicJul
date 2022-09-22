using Unity.VisualScripting;
using UnityEngine;

public class Enemy_Heritage : MonoBehaviour
{
    [HideInInspector] public Enemy_Attack enemy_Attack;
    [HideInInspector] public Enemy_IA enemy_IA;
    [HideInInspector] public Enemy_Jump enemy_Jump;
    [HideInInspector] public Enemy_Move enemy_Move;
    [HideInInspector] public Enemy_Throw enemy_Throw;
    [HideInInspector] public Enemy_Animation enemy_Animation;
    [HideInInspector] public Enemy_Loot enemy_Loot;

    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public SpriteRenderer spriteR;
    [HideInInspector] public Animator animator;
    [HideInInspector] public BoxCollider2D attackCollider;

    [HideInInspector] public GameObject player;

    virtual public void Awake()
    {
        enemy_Attack =      GetComponent<Enemy_Attack>();
        enemy_IA =          GetComponent<Enemy_IA>();
        enemy_Jump =        GetComponent<Enemy_Jump>();
        enemy_Move =        GetComponent<Enemy_Move>();
        enemy_Throw =       GetComponent<Enemy_Throw>();
        enemy_Animation =   GetComponent<Enemy_Animation>();
        enemy_Loot =        GetComponent<Enemy_Loot>();

        rb =                GetComponent<Rigidbody2D>();
        spriteR =           GetComponent<SpriteRenderer>();
        animator =          GetComponent<Animator>();

        player = GameObject.FindGameObjectWithTag("Player");

        attackCollider = transform.Find("Attack").GetComponent<BoxCollider2D>();
        attackCollider.enabled = false;
    }
}
