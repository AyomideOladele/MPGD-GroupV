using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int MaxHealth = 100;

    public HealthBar healthBar;
    public GameState gameState;
    [SerializeField] GameObject player;
    [SerializeField] GameObject gameStateManager;

    [SerializeField]
    private int currentHealth;
    public int CurrentHealth
    {
        get { return currentHealth; }
        private set { currentHealth = value; }
    }

    private void Start()
    {
        // Retrieve healthbar script and game state script
<<<<<<< HEAD
=======
        healthBar = player.GetComponent<HealthBar>();
        gameState = gameStateManager.GetComponent<GameState>();
>>>>>>> 01ddb483f1ca137f3c45135e3087d9e3ff5a0312

        currentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0) currentHealth = 0;
        healthBar.SetHealth(currentHealth);

        Debug.Log("Player Health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Player has died!");

        gameState.gameOver(); // Displays game over screen
    }
}

