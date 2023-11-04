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
    }
}
