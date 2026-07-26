using UnityEngine;

public abstract class AbilitySO : ScriptableObject
{
    public string abilityName;
    public float cooldown;
    public float increaseAmount;
    public float damage;
    public Sprite icon;

    public abstract void Activate(Transform player);
}