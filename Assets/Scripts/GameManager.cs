using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timeCount = 60f;
    public int displayCooldown;

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

    void Start()
    {
        displayCooldown = Mathf.CeilToInt(timeCount);
    }

    void Update()
    {
        timeCount -= Time.deltaTime;
        displayCooldown = Mathf.CeilToInt(timeCount);
    }

    public void GameOver()
    {
        
    }
}
