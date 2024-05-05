using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager
{
    private PlayerInputs playerInputs;

    public event Action<bool> OnParry;

    public float MoveDirection => playerInputs.Movement.Walk.ReadValue<float>();

    public InputManager()
    {
        playerInputs = new PlayerInputs();
        playerInputs.Enable();
        playerInputs.Combat.Parry.started += ParryPerfomed;
    }

    public void ParryPerfomed(InputAction.CallbackContext context)
    {
        OnParry?.Invoke(context.ReadValueAsButton());
    }
}
