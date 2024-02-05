using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public static PlayerInput Instance;

    [SerializeField] private float _moveSpeed = 3;

    public Transform PlayerTransform {get; private set;}
    public Vector3 MousePoint {get; private set;}

    private Vector2 _moveDirection;
    private InputSystem _playerInput;
    private CharacterController _characterController;
    private Camera _mainCamera;

    private void Update()
    {
        ReadMousePoint();
    }

    private void FixedUpdate()
    {
        PlayerMove();
        RotationPlayer();
    }

    private void Init()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
        PlayerTransform = GetComponent<Transform>();

        _playerInput = new InputSystem();
        _characterController = GetComponent<CharacterController>();
        _mainCamera = Camera.main;
    }

    private void OnEnable()
    {
        _playerInput.Enable();

        _playerInput.Player.Move.performed += OnMoveDirectionPerformed;
        _playerInput.Player.Move.performed += OnMoveDirectionCancelled;
    }

    private void OnDisable()
    {
        _playerInput.Disable();

        _playerInput.Player.Move.performed -= OnMoveDirectionPerformed;
        _playerInput.Player.Move.performed -= OnMoveDirectionCancelled;
    }

    private void OnMoveDirectionPerformed(InputAction.CallbackContext context)
    {
        _moveDirection = context.ReadValue<Vector2>();
    }

    private void OnMoveDirectionCancelled(InputAction.CallbackContext context)
    {
        _moveDirection = Vector2.zero;
    }
    
    private void PlayerMove()
    {
        _characterController.Move(_moveDirection * _moveSpeed * Time.deltaTime);
    }

    private void ReadMousePoint()
    {        
        Ray mousePointRay = _mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
        Physics.Raycast(mousePointRay, out RaycastHit mouseRaycastHit);
        MousePoint = mouseRaycastHit.point;
    }

    private void RotationPlayer()
    {
        var dist = transform.position - MousePoint;
        Quaternion rotation = Quaternion.LookRotation(dist, transform.TransformDirection(Vector3.up));
        transform.rotation = new Quaternion(0, rotation.y, 0, rotation.w);
    }
}
