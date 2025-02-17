using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI gameOverText;

    private int lives = 3;
    private int score = 0;
    private bool isGameOver = false;

    void Start()
    {
        gameOverText.gameObject.SetActive(false); 
        UpdateUI();
    }

    void Update()
    {
        if (isGameOver && Input.GetKeyDown(KeyCode.R)) 
        {
            RestartGame();
        }
    }

    public void IncreaseScore()
    {
        if (!isGameOver)
        {
            score++;
            UpdateUI();
        }
    }

    public void DecreaseLives()
    {
        if (!isGameOver)
        {
            lives--;
            UpdateUI();

            if (lives <= 0)
            {
                GameOver();
            }
        }
    }

    private void UpdateUI()
    {
        scoreText.text = "Score: " + score;
        Debug.Log("Score: " + score);
        livesText.text = "Lives: " + lives;
        Debug.Log("Lives: " + lives);
    }

    public void PlayerHit()
    {
        DecreaseLives();
    }

    private void GameOver()
    {
        isGameOver = true;
        gameOverText.gameObject.SetActive(true); 
        Debug.Log("Game Over");
        Time.timeScale = 0f; 
    }

    private void RestartGame()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
