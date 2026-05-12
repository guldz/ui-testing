using UnityEngine;
using UnityEngine.InputSystem;
using Unity.VisualScripting;
using System.Collections;
public class Movement : MonoBehaviour

{
    Rigidbody2D rb;
    public bool isMoving = true;
    public float moveSpeed = 5f;
    private Vector2 moveInput;

   

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

 
    void Update()
    {
        GetMovementInput();
        Move();

    }

    private void Move()
    {
        transform.position += (Vector3)(moveInput * moveSpeed * Time.deltaTime);
    }
    private void GetMovementInput()
    {

        moveInput = Keyboard.current.wKey.isPressed ? Vector2.up : Vector2.zero;
        if (Keyboard.current.sKey.isPressed) moveInput += Vector2.down;
        if (Keyboard.current.aKey.isPressed) moveInput += Vector2.left;
        if (Keyboard.current.dKey.isPressed) moveInput += Vector2.right;

        moveInput = moveInput.normalized;
        isMoving = moveInput != Vector2.zero;
    }
}
