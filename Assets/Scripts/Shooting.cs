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

    void Update()
    {
        
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        float startAngle = shotCount > 1 ? -spreadAngle / 2f : 0f;
        float angleStep = shotCount > 1 ? spreadAngle / (shotCount - 1) : 0f;

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
