using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/MovementSpeed")]
public class MovementSpeed : AbilitySO
{
    public override void Activate(Transform player)
    {
        PlayerMovement movement = player.GetComponent<PlayerMovement>();
        movement.moveSpeed += 2f;
    }
}
