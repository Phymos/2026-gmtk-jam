using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timeCount = 60f;
    public int displayCooldown;
    public GameObject panel;

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
        panel.SetActive(true);
    }

    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void AddTime(float time)
    {
        timeCount += time;
    }
}
