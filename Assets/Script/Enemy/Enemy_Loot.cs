using UnityEngine;

public class Enemy_Loot : Enemy_Heritage
{
    public Loot loot;

    public void Loot()
    {
        float luckRoll = Random.Range(0, 100f);
        float previousProbability = 0f;

        for (int i = 0; i < loot.lootableItemlist.Count; i++)
        {
            if (luckRoll <= loot.lootableItemlist[i].probability + previousProbability
                && luckRoll >= previousProbability)
            {
                Instantiate(loot.lootableItemlist[i].obj, transform.position, Quaternion.identity);
            }
            previousProbability += loot.lootableItemlist[i].probability;
        }
    }
}
