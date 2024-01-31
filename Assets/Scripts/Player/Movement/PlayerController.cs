using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    Vector2 moveTransform;
    Vector3 targetPos;
    Action<Vector2> OnMoving;

    public void Init()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void SubsctibeToMove(Action<Vector2> move)
    {
        OnMoving += move;
    }

    private void FixedUpdate()
    {
        rb.velocity = new(moveTransform.x, 0, moveTransform.y);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveTransform = context.ReadValue<Vector2>() * Player.Instance.Movespeed.Value;
        OnMoving?.Invoke(context.ReadValue<Vector2>());
    }
    public void OnAim(InputAction.CallbackContext context) 
    {
        targetPos = context.ReadValue<Vector2>();
    }
    public Vector3 GetMousePoint()
    {
        Ray moucePos = Camera.main.ScreenPointToRay(targetPos);
        Physics.Raycast(moucePos, out RaycastHit mouseTransform);
        Vector3 mouse = mouseTransform.point;
        var dist = transform.position - mouse;
        Quaternion rotation = Quaternion.LookRotation(dist, transform.TransformDirection(Vector3.up));
        transform.rotation = new Quaternion(0, rotation.y, 0, rotation.w);
        return mouse;
    }
}
