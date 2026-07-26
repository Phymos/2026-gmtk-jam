using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/BulletSpeed")]
public class BulletSpeed : AbilitySO
{

    public override void Activate(Transform player)
    {
        Shooting shooting = player.GetComponent<Shooting>();
        shooting.bulletForce += 5;
    }
}
