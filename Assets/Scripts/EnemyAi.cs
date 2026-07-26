using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public Rigidbody2D rb;
    public float MoveSpeed = 5f;
    public float addedTime = 2f;
    private EnemyStats enemyStats;

    void Start()
    {
        enemyStats = GetComponent<EnemyStats>();
    }

    void FixedUpdate()
    {
        Vector2 newPos = Vector2.MoveTowards(rb.position, playerRb.position, MoveSpeed * Time.fixedDeltaTime);
        rb.MovePosition(newPos);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            PlayerStats playerStats = collision.collider.GetComponent<PlayerStats>();
            playerStats.currentHealth -= enemyStats.damage;
            if (playerStats.currentHealth <= 0)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}
