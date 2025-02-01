using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public HealthBarUI healthBar; 
    public bool nextLevelChecker = false;

    void Start()
    {
        currentHealth = maxHealth;
        if (healthBar != null)
        {
            healthBar.SetMaxHealth(maxHealth);
        }
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        Debug.Log($"{gameObject.name} took {amount} damage! Current Health: {currentHealth}");

        if (healthBar != null)
        {
            healthBar.SetHealth(currentHealth);
        }

        if (currentHealth <= 0)
        {
            if (gameObject.name == ("Boss"))
            {
                nextLevelChecker = true;
            }
            if (gameObject.name == ("Hero"))
            {
                SceneManager.LoadScene(6);
                Debug.Log("Game Over!");
            }
            Die();
            NextLevel();
        }
    }

    void Die()
    {
        Debug.Log($"{gameObject.name} has died!");
        Destroy(gameObject);
    }

    void NextLevel()
    {
        if (nextLevelChecker)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        Debug.Log(SceneManager.GetActiveScene().buildIndex + 1);
        if (nextLevelChecker && SceneManager.GetActiveScene().buildIndex + 1 == 5)
        {
            SceneManager.LoadScene(5);
        }
    }
}
