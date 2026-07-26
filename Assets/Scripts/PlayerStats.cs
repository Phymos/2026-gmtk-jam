using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [HideInInspector]
    public float currentHealth = 4f;

    public float maxHealth;
    public float damage;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        Debug.Log("Current Health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            GameManager.Instance.GameOver();
        }
    }
}
