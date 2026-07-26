using System.Collections;
using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/Dash")]
public class Dashing : AbilitySO
{
    public float dashSpeed = 20f;
    public float dashDuration = 0.2f;

    public override void Activate(Transform player)
    {
        PlayerMovement movement = player.GetComponent<PlayerMovement>();
        movement.StartCoroutine(DoDash(player, movement.lastMoveDirection));
    }

    private IEnumerator DoDash(Transform player, Vector2 inputDir)
    {
        Vector3 dashDir = new Vector3(inputDir.x,0 , inputDir.y).normalized;

        float timer = 0f;
        while (timer < dashDuration)
        {
            player.position += dashDir * dashSpeed * Time.deltaTime;
            timer += Time.deltaTime;
            yield return null;
        }
    }
}
