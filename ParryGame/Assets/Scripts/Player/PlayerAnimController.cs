using System;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    private Animator animator;

    private bool isMoving => PlayerBehavior.instance.moveDirection != Vector2.zero;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        GameManager.Instance.inputManager.OnParry += ParryAnimHandler;
    }

    private void Update()
    {
        WalkHandler();
    }

    private void ParryAnimHandler(bool isParrying)
    {
        animator.SetTrigger("parryPressed");    
    }

    private void WalkHandler()
    {
        animator.SetBool("isMoving", isMoving);
    }
}
