using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private Transform attackPoint;
    [SerializeField] private Vector3 attackSize;
    private bool attackArea;

    private void AttackHandler()
    {
        attackArea = Physics2D.OverlapBox(attackPoint.position, attackSize, 0);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(attackPoint.position, attackSize);
    }
}
