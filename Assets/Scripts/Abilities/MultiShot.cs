using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/MultiShot")]
public class MultiShot : AbilitySO
{
    public override void Activate(Transform player)
    {
        Shooting shooting = player.GetComponent<Shooting>();
        shooting.shotCount += 1;
    }
}