using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollision : MonoBehaviour
{
    public PlayerCombat _playerCombat;
    public bool _canBeAttacked = false;
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Debug.Log("Can be attacked");
            _canBeAttacked = true;


        }



    }
}
