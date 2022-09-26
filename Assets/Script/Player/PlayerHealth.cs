using UnityEngine;

public class PlayerHealth : MonoBehaviour



{
    public PlayerHealthbar playerHealthbar;
    
    public float lifeMax;
    float lifeCurrent;

    private Animator animator;

    void Start()
    {
        lifeCurrent = lifeMax;
        playerHealthbar.SetMaxHealth(lifeMax);
        animator = GetComponentInChildren<Animator>();
    }

    public void LifeCurrentAdd(float value)
    {
        lifeCurrent -= value;
        playerHealthbar.SetHealth(lifeCurrent);
        animator.SetTrigger("receivedDamage");

        if (lifeCurrent <= 0)
        {
            Die();
        }
    }
    
    private void Die()
        
    {
     // Play Player Death animation
     animator.SetBool("isDead", true);

     Debug.Log("Player died!");

    }
}
