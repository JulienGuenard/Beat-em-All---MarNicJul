using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollision : MonoBehaviour
{
    public PlayerCombat _playerCombat;
    
    [HideInInspector] // attribute for hiding variables in the inspector
    public GameObject selectedEnemy;

    [HideInInspector]
    public bool _canBeAttacked = false;
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("Can be attacked");
            _canBeAttacked = true;
            selectedEnemy = other.gameObject;
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("Can not be attacked");
            _canBeAttacked = false;
        }
    }
}
