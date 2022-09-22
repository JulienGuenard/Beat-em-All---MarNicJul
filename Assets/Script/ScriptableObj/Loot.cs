using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Loot", order = 1)]
public class Loot : ScriptableObject
{
    [System.Serializable]
   public class LootableItem
    {
        public GameObject obj;
        public float probability;
    }

    public List<LootableItem> lootableItemlist;
}
