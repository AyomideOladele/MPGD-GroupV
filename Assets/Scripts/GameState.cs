using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    public GameObject gameOverScreen;

    // Restarts current game scene
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Displays Game Over screen to player
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
<<<<<<< HEAD
        Time.timeScale = 0f;
    }
    // Call this method to restart time when starting a new game or loading a level
    public void RestartTime()
    {
        Time.timeScale = 1f;
    }
    void Update()
    {
        // Restart the level if the player presses the R key after winning
        if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.R))
        {
            RestartTime();
            // Reload the current scene
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }
    }

=======
    }
>>>>>>> 01ddb483f1ca137f3c45135e3087d9e3ff5a0312
}
