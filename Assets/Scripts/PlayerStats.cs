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
}
