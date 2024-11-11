using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager
{
    private InputControls inputControls;

    public event Action OnParry;

    public float MoveDirection => inputControls.PlayerActions.Walk.ReadValue<float>();

    public InputManager()
    {
        inputControls = new InputControls();
        EnablePlayerInput();

        inputControls.PlayerActions.Parry.performed += OnParryPerformed;
    }

    private void OnParryPerformed(InputAction.CallbackContext obj) => OnParry?.Invoke();


    public void EnablePlayerInput() => inputControls.PlayerActions.Enable();
    public void DisablePlayerInput() => inputControls.PlayerActions.Disable();
}
