using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;

    private int lives = 3;
    private int score = 0;

    void Start()
    {
        UpdateUI();
    }

    public void IncreaseScore()
    {
        score++;
        UpdateUI();
    }

    public void DecreaseLives()
    {
        lives--;
        UpdateUI();

        if (lives <= 0)
        {
            Debug.Log("Game Over");
        }
    }

    private void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;
    }
}

