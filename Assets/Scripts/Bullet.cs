using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;

    void OnCollisionEnter2D(Collision2D collision)
    {
        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 2f);
        Destroy(gameObject);

        if (collision.collider.CompareTag("Enemy"))
        {
            EnemyStats enemyStat = collision.collider.GetComponent<EnemyStats>();
            enemyStat.health -= 1;
        }
    }
}
