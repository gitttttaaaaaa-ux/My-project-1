using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public Transform player;
    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    private float startX;
    private int score;
    private int highScore;

    void Start()
    {
        startX = player.position.x;

        highScore = PlayerPrefs.GetInt("HighScore", 0);

        UpdateUI();
    }

    void Update()
    {
        float distance = player.position.x - startX;

        if (distance < 0)
            distance = 0;

        score = Mathf.FloorToInt(distance);

        if (score > highScore)
        {
            highScore = score;

            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }

        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        highScoreText.text = "High Score: " + highScore;
    }
}