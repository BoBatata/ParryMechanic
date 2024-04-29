using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    public static PlayerBehavior instance;
    public PlayerInputs playerinputs;

    private Vector2 moveDirection;
    [SerializeField] private float velocity = 10;
    private bool isParrying;
    private Rigidbody2D rigibody;

    private void Awake()
    {
        instance = this;
        PlayerInputs();
        rigibody = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        MoveHandler();
    }

    private void MoveHandler()
    {
        if (moveDirection.x < 0)
        {
            transform.rotation = new Quaternion(0, -180, 0, 0);
        }
        else if (moveDirection.x > 0)
        {
            transform.rotation = quaternion.identity;
        }
        moveDirection.x = playerinputs.Movement.Walk.ReadValue<float>();
        rigibody.velocity = new Vector2(moveDirection.x * velocity, rigibody.velocity.y);

    }
    private void PlayerInputs()
    {
        playerinputs = new PlayerInputs();
    }

    private void OnEnable()
    {
        playerinputs.Enable();   
    }

    private void OnDisable()
    {
        playerinputs.Disable();
    }
}
