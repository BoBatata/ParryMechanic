using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ParryBehavior : MonoBehaviour
{
    [SerializeField] private Transform parryPoint;
    [SerializeField] private Vector3 parrySize;
    [SerializeField] private LayerMask parryMask;
    private PlayerInputs playerInputs;
    private bool parryPressed;
    private Color parryColor; 
    private bool canParry;

    private void Start()
    {
        GameManager.Instance.inputManager.OnParry += ParryHandler;  
    }

    private void Update()
    {
        AttackHandler();
        print(canParry);
        print(parryPressed);
    }

    private void ParryHandler(bool isParrying)
    {
        if (isParrying)
        {
            parryPressed = true;
        }
        else if (!isParrying)
        {
            parryPressed = false;
        }
    }

    private void AttackHandler()
    {
        if (parryPressed)
        {
            canParry = Physics2D.OverlapBox(parryPoint.position, parrySize, 0, parryMask);
            parryColor = Color.green;
        }
        else
        {
            canParry = false;
            parryColor = Color.red;
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = parryColor;
        Gizmos.DrawWireCube(parryPoint.position, parrySize);
    }


}
