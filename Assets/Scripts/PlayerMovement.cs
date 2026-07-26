using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    public Camera cam;

    private Vector2 movementInput;
    private Vector2 mousePos;

    void Update()
    {
        Vector2 screenPos = Mouse.current.position.ReadValue();
        mousePos = cam.ScreenToWorldPoint(screenPos);;
    } 

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movementInput * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;

        rb.MoveRotation(angle); 
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }
}
