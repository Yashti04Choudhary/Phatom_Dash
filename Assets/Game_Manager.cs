using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject gameOverPanel;
    public GameObject segmentSpawner;
    public GameObject liveScoreUI;

    void Start()
    {
        Time.timeScale = 0f;

        startPanel.SetActive(true);
        gameOverPanel.SetActive(false);
        segmentSpawner.SetActive(false);   //  stop spawning at start
        liveScoreUI.SetActive(false);
    }

    public void StartGame()
    {
        Time.timeScale = 1f;

        startPanel.SetActive(false);
        segmentSpawner.SetActive(true);    //  start spawning now
        liveScoreUI.SetActive(true);
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}