using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    public int shotCount = 1;
    public float spreadAngle = 30f;
    public float shotCooldown = 0.3f;

    public float cooldownTimer = 0f;
    private bool wantsToShoot = false;

    void Update()
    {
        if (cooldownTimer > 0f)
        {
            cooldownTimer -= Time.deltaTime;
        }

        if (wantsToShoot && cooldownTimer <= 0f)
        {
            Shoot();
            cooldownTimer = shotCooldown;
        }
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            wantsToShoot = true;
        }
        else if (context.canceled)
        {
            wantsToShoot = false;
        }
    }

    void Shoot()
    {
        float startAngle = shotCount > 1 ? -spreadAngle / 2f : 0f;
        float angleStep = shotCount > 1 ? spreadAngle / (shotCount - 1) : 0f;

        for (int i = 0; i < shotCount; i++)
        {
            float angle = startAngle + angleStep * i;
            Quaternion rot = firePoint.rotation * Quaternion.Euler(0, 0, angle);

            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, rot);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(rot * Vector2.up * bulletForce, ForceMode2D.Impulse);
        }
    }
}
