using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    public Camera cam;

    [HideInInspector]
    public Vector2 movementInput;
    public Vector2 lastMoveDirection;
    
    private Vector2 mousePos;
    public Animator animator;

    public Transform aimPivot;

    void Update()
    {
        if (movementInput != Vector2.zero)
        {
            lastMoveDirection = movementInput;
        }
        
        Vector2 screenPos = Mouse.current.position.ReadValue();
        mousePos = cam.ScreenToWorldPoint(screenPos);

        Vector2 aimDir = (mousePos - (Vector2)transform.position).normalized;

        animator.SetFloat("AimX", aimDir.x);
        animator.SetFloat("AimY", aimDir.y);

        Vector2 lookDir = mousePos - (Vector2)aimPivot.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        aimPivot.rotation = Quaternion.Euler(0, 0, angle);
    } 

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movementInput * moveSpeed * Time.fixedDeltaTime);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }
}
