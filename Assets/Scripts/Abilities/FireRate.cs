using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/FireRate")]
public class FireRate : AbilitySO
{
    public override void Activate(Transform player)
    {
        Shooting shooting = player.GetComponent<Shooting>();
        shooting.cooldownTimer -= 0.05f;
    }
}
