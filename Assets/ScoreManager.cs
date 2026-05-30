using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI liveScoreText;
    public TextMeshProUGUI finalScoreText;
    public GameObject milestoneText;
    private int nextMilestone = 1000;

    private float startZ;
    private int score;

    void Start()
    {
        startZ = player.position.z;
    }

    void Update()
    {
        score = Mathf.FloorToInt(player.position.z - startZ);

        if (liveScoreText != null)
        {
            liveScoreText.text = score.ToString();
        }
        if (score >= nextMilestone)
        {
            ShowMilestone(nextMilestone);
            nextMilestone += 1000;
        }
    }

    void ShowMilestone(int milestone)
    {
        milestoneText.SetActive(true);
        milestoneText.GetComponent<TextMeshProUGUI>().text = milestone + " Reached!! :)";
        Invoke("HideMilestone", 2.5f);
    }

    void HideMilestone()
    {
        milestoneText.SetActive(false);
    }
    public void ShowFinalScore()
    {
        finalScoreText.text = "Your Score : " + score;
    }
}