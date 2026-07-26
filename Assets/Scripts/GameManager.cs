using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float Time = 60f;

    public static GameManager Instance;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void GameOver()
    {
        
    }
}
