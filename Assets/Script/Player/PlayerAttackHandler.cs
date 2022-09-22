using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackHandler : MonoBehaviour
{
    [SerializeField] private GameObject attackCollider;

    public void EnableAttack()
    {
        attackCollider.SetActive(true);

    }

    public void DisableAttack()
    {
        attackCollider.SetActive(false);

    }

}
