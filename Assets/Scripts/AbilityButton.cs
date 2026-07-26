using UnityEngine;

public class AbilityButton : MonoBehaviour
{
    public AbilitySO abilitySO;
    public Transform playerTransform;
    
    public float timeCost = 10f; 

    void Start()
    {
        if (playerTransform == null)
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            if (playerObj != null) playerTransform = playerObj.transform;
        }
    }

    public void SelectAbility()
    {
        if (abilitySO != null && playerTransform != null)
        {
            abilitySO.Activate(playerTransform);

            if (GameManager.Instance != null)
            {
                GameManager.Instance.AddTime(-timeCost);
            }

            transform.root.gameObject.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
