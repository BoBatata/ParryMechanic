using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackBehavior : MonoBehaviour
{
    [SerializeField] private Transform attackPoint;
    [SerializeField] private Vector3 attackSize;
    [SerializeField] private LayerMask attackMask;
    [SerializeField] private float attackAngle;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(attackPoint.position, attackSize);
    }

    private void AttackHandler()
    {
        Collider2D hittedEnemies = Physics2D.OverlapBox(attackPoint.position, attackSize, attackAngle);
    }

}
