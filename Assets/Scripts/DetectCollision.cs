using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public int health = 3; 

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
