using UnityEngine;

public class EnemyHealth : Enemy_Heritage
{
    public int maxHealth = 100;
    public int currentHealth;
    public Animator lifeBarAnimator;
    public GameObject lifeBarFX;

    new void Awake()
    {
        base.Awake();
        currentHealth = maxHealth;
        lifeBarAnimator = transform.Find("Graphic").transform.Find("EnemyLifeBar").GetComponent<Animator>();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        lifeBarAnimator.gameObject.SetActive(true);
        float lifePercent = 1f - ((float)currentHealth / (float)maxHealth);
        lifeBarAnimator.Play("LifeBar_Fill", 0, lifePercent);

        GameObject fx = Instantiate(lifeBarFX, lifeBarAnimator.transform.position, Quaternion.identity);
        fx.transform.SetParent(lifeBarAnimator.transform);
        fx.transform.localScale = new Vector3(1, 1, 1);

        if (currentHealth <= 0)
        {
            lifeBarAnimator.gameObject.SetActive(false);
            Die();
        }

    }

    private void Die()
    {
		Debug.Log("Enemy died!");
        enemy_Loot.Loot();
        enemy_Animation.AnimationDead();
    }
}
