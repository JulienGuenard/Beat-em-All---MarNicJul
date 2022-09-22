using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollision : MonoBehaviour
{
    public PlayerCombat _playerCombat;
    
    //[HideInInspector] // attribute for hiding variables in the inspector
    public List<GameObject> enemyList;
    
    

    [HideInInspector]
    public bool _getsPunched = false;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("Gets punched");
            _getsPunched = true;
            enemyList.Add(other.gameObject);
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("Can not be attacked");
            _getsPunched = false;
            enemyList.Remove(other.gameObject);

        }
    }
}
