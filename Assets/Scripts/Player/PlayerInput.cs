using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{       
    private InputSystem _playerInput;    

    private void Awake()
    {
        _playerInput = new InputSystem();
    }

    private void OnEnable()
    {
        _playerInput.Enable();

        _playerInput.Gameplay.Move.performed += OnMoveDirectionPerformed;
        _playerInput.Gameplay.Move.canceled += OnMoveDirectionCancelled;
    }

    private void OnDisable()
    {
        _playerInput.Disable();

        _playerInput.Gameplay.Move.performed -= OnMoveDirectionPerformed;
        _playerInput.Gameplay.Move.canceled -= OnMoveDirectionCancelled;
    }

    private void OnMoveDirectionPerformed(InputAction.CallbackContext context)
    {
        PlayerController.Instance.DirectionMove = context.ReadValue<Vector2>();
    }

    private void OnMoveDirectionCancelled(InputAction.CallbackContext context)
    {
        PlayerController.Instance.DirectionMove = Vector2.zero;
    }    
}
