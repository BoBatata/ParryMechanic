using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParryBehavior : MonoBehaviour
{
    [SerializeField] private Transform parryPoint;
    [SerializeField] private Vector3 parrySize;
    [SerializeField] private LayerMask parryMask;
    [SerializeField] private Collider2D canParry;

    private void Update()
    {
        print(canParry);
    }

    private void AttackHandler()
    {
        canParry = Physics2D.OverlapBox(parryPoint.position, parrySize, parryMask);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(parryPoint.position, parrySize);
    }


}
