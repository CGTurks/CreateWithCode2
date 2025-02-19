using UnityEngine;
using UnityEngine.UI; // Import UI namespace

public class DetectCollision : MonoBehaviour
{
    public int health = 3;
    public Slider hungerBar; // Reference to the Hunger Bar UI

    void Start()
    {
        if (hungerBar != null)
        {
            hungerBar.maxValue = health;
            hungerBar.value = 0; // Start empty
        }
    }

    void OnTriggerEnter(Collider other)
    {
        GameManager gameManager = FindObjectOfType<GameManager>();

        if (other.CompareTag("Player"))
        {
            if (gameManager != null)
            {
                gameManager.PlayerHit();
            }

            Destroy(gameObject);
        }
        else if (other.CompareTag("Projectile"))
        {
            health--;

            if (hungerBar != null)
            {
                hungerBar.value += 1; // Fill up the hunger bar
            }

            if (health <= 0)
            {
                if (gameManager != null)
                {
                    gameManager.IncreaseScore();
                }

                Destroy(gameObject);
            }

            Destroy(other.gameObject);
        }
    }
}
