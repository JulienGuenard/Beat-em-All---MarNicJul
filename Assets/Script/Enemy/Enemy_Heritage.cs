using UnityEngine;

public class Enemy_Heritage : MonoBehaviour
{
    [HideInInspector] public Enemy_Attack enemy_Attack;
    [HideInInspector] public Enemy_IA enemy_IA;
    [HideInInspector] public Enemy_Jump enemy_Jump;
    [HideInInspector] public Enemy_Move enemy_Move;
    [HideInInspector] public Enemy_Throw enemy_Throw;
    [HideInInspector] public Enemy_Animation enemy_Animation;

    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public SpriteRenderer spriteR;
    [HideInInspector] public Animator animator;

    [HideInInspector] public GameObject player;

    void Awake()
    {
        enemy_Attack =      GetComponent<Enemy_Attack>();
        enemy_IA =          GetComponent<Enemy_IA>();
        enemy_Jump =        GetComponent<Enemy_Jump>();
        enemy_Move =        GetComponent<Enemy_Move>();
        enemy_Throw =       GetComponent<Enemy_Throw>();
        enemy_Animation =   GetComponent<Enemy_Animation>();

        rb =                GetComponent<Rigidbody2D>();
        spriteR =           GetComponent<SpriteRenderer>();
        animator =          GetComponent<Animator>();

        player =            GameObject.FindGameObjectWithTag("Player");
    }
}
