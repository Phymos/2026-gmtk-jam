using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timeCount = 60f;
    public int displayCooldown;
    public GameObject panel;

    public GameObject abilitySelectionScreen;
    public float[] abilityTriggerTimes = { 15f, 30f, 30f, 45f };
    private int nextAbilityIndex = 0;

    public TextMeshProUGUI timerText;
    public static GameManager Instance;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        displayCooldown = Mathf.CeilToInt(timeCount);
    }

    void Update()
    {
        timeCount -= Time.deltaTime;
        displayCooldown = Mathf.CeilToInt(timeCount);
        timerText.text = displayCooldown.ToString();

        if (nextAbilityIndex < abilityTriggerTimes.Length &&
            timeCount <= abilityTriggerTimes[nextAbilityIndex])
        {
            ShowAbilitySelection();
            nextAbilityIndex++;
        }

        if (timeCount <= 0)
        {
            GameOver();
        }
    }

    void ShowAbilitySelection()
    {
        Time.timeScale = 0f;
        abilitySelectionScreen.SetActive(true);
    }

    public void GameOver()
    {
        panel.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void AddTime(float time)
    {
        timeCount += time;
    }
}
