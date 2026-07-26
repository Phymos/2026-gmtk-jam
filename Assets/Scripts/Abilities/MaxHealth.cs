using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/MaxHealth")]
public class MaxHealth : AbilitySO
{
    public override void Activate(Transform player)
    {
        PlayerStats playerStats = player.GetComponent<PlayerStats>();
        playerStats.maxHealth += increaseAmount;
        playerStats.currentHealth = playerStats.maxHealth;
    }
}
