using UnityEngine;

public class PlayerHealth : MonoBehaviour



{
    public float lifeMax;
    float lifeCurrent;

    private Animator animator;

    void Start()
    {
        lifeCurrent = lifeMax;
    }

    public void LifeCurrentAdd(float value)
    {
        lifeCurrent -= value;
        if(lifeCurrent <= 0)
        {
            Die();
        }
    }
    
    private void Die()
        
    {
     Debug.Log("Player died!");
     // Play Player Death animation
     animator.SetBool("isDead", true);


    }
}
