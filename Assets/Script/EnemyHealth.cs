using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Enemy_Heritage
{
    public int maxHealth = 100;
    public int currentHealth;
    public Animator lifeBarAnimator;
    public GameObject lifeBarFX;
    public List<AudioClip> hurtSFXList;
    public List<AudioClip> dieSFXList;
    private AudioSource audioS;

    new void Awake()
    {
        base.Awake();
        currentHealth = maxHealth;
        lifeBarAnimator = transform.Find("Graphic").transform.Find("EnemyLifeBar").GetComponent<Animator>();
        audioS = GetComponent<AudioSource>();
    }

    public void TakeDamage(int damage)
    {

        currentHealth -= damage;
        lifeBarAnimator.gameObject.SetActive(true);
        float lifePercent = 1f - ((float)currentHealth / (float)maxHealth);
        lifeBarAnimator.Play("LifeBar_Fill", 0, lifePercent);

        if (currentHealth <= 0)
        {
            lifeBarAnimator.gameObject.SetActive(false);
            audioS.PlayOneShot(dieSFXList[Random.Range(0, dieSFXList.Count)]);
            Die();
        }else
        {
            audioS.PlayOneShot(hurtSFXList[Random.Range(0, hurtSFXList.Count)]);
            GameObject fx = Instantiate(lifeBarFX, lifeBarAnimator.transform.position, Quaternion.identity);
            fx.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    private void Die()
    {
		Debug.Log("Enemy died!");
        enemy_Loot.Loot();
        enemy_Animation.AnimationDead();
    }
}
