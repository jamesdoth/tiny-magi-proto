using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    public Vector2 RawMovementInput { get; private set; }
    public int NormInputX { get; private set; }
    public int NormInputY { get; private set; }
    private PlayerInput playerInput;

    private Teleport teleportScript;

    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        RawMovementInput = context.ReadValue<Vector2>();

        NormInputX = (int)(RawMovementInput * Vector2.right).normalized.x;
        NormInputY = (int)(RawMovementInput * Vector2.up).normalized.y;
    }

    public void OnShootInput(InputAction.CallbackContext context)
    {
        
    }
    public void OnTeleportInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            teleportScript.TeleportToMousePosition();
        }
    }

    public bool IsTeleportInput()
    {
        return playerInput.actions["Gameplay/Ability"].triggered && playerInput.actions["Gameplay/Ability"].activeControl.name == "e";
    }
}
