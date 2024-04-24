using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    private PlayerInputs playerinputs;

    private Vector2 moveDirection;
    [SerializeField] private float velocity = 10;
    private Rigidbody2D rigibody;

    private void Awake()
    {
        playerinputs = new PlayerInputs();
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

    private void OnEnable()
    {
        playerinputs.Enable();   
    }

    private void OnDisable()
    {
        playerinputs.Disable();
    }
}
