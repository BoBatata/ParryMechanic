using System;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        GameManager.Instance.inputManager.OnParry += ParryAnimHandler;
    }

    private void ParryAnimHandler(bool isParrying)
    {
        animator.SetTrigger("parryPressed");    
    }
}
