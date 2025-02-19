using UnityEngine;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour
{
    public int health = 3;
    public Slider hungerBar; 

    void Start()
    {
        if (hungerBar != null)
        {
            hungerBar.maxValue = health;
            hungerBar.value = 0; 
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
                hungerBar.value += 1; 
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
