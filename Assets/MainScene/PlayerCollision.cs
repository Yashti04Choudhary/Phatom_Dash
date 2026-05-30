using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject gameOverPanel;
    public ScoreManager scoreManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOverPanel.SetActive(true);

            if (scoreManager != null)
            {
                scoreManager.ShowFinalScore();
            }

            Time.timeScale = 0f;
        }
    }
}