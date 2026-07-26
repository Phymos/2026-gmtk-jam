using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float health;
    public float damage;
    public float addedTime = 2f;

    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        GameManager.Instance.AddTime(addedTime);
        Destroy(gameObject);
    }
}
