using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAbilities : MonoBehaviour
{
    public Dashing dashAbility;
    private float dashCooldownTimer = 0f;

    void Update()
    {
        dashCooldownTimer -= Time.deltaTime;
    }

    public void OnDash(InputAction.CallbackContext context)
    {
        if (context.performed && dashCooldownTimer <= 0)
        {
            dashAbility.Activate(transform);
            dashCooldownTimer = dashAbility.cooldown;
        }
    }
}
