using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public Rigidbody2D rb;
    public float MoveSpeed = 5f;

    void FixedUpdate()
    {
        rb.MovePosition(playerRb.position * MoveSpeed * Time.deltaTime);

        Vector2 lookDir = playerRb.position - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;

        rb.MoveRotation(angle);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            PlayerStats playerStats = collision.collider.GetComponent<PlayerStats>();
            playerStats.health -= 1;
        }
    }
}
