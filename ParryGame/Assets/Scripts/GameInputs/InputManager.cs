using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInputs playerInputs;

    public event Action<bool> OnParry;

    public float MoveDirection => playerInputs.Movement.Walk.ReadValue<float>();

    public InputManager()
    {
        playerInputs = new PlayerInputs();
        playerInputs.Enable();
        playerInputs.Combat.Parry.performed += ParryPerfomed;
        playerInputs.Combat.Parry.canceled += ParryPerfomed;
    }

    public void ParryPerfomed(InputAction.CallbackContext context)
    {
        OnParry?.Invoke(context.ReadValueAsButton());
    }
}
