using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int MaxHealth = 100;

    [SerializeField]
    private int currentHealth;
    public int CurrentHealth
    {
        get { return currentHealth; }
        private set { currentHealth = value; }
    }

    private void Start()
    {
        currentHealth = MaxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0) currentHealth = 0;

        Debug.Log("Player Health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Player has died!");
        // Add death logic here
    }
}

