using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text counterText;
    public GameObject winText;
    public int totalItemCount; // Total Item number
    private int itemsRemaining;// The number of item remaining


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        // Initialize itemsRemaining with the total items to collect
        itemsRemaining = totalItemCount;
        UpdateCounterText(); // Update the UI text on start
    }
    //Counter for remaining time, if item is = 0----> win
    public void ItemCollected()
    {
        itemsRemaining--;
        UpdateCounterText();

        if (itemsRemaining <= 0)
        {
           WinGame();
        }
    }
    //Update the number of item
    private void UpdateCounterText()
    {
        if (counterText != null)
        {
            counterText.text = "Items Remaining: " + itemsRemaining;
        }
        else
        {
            Debug.LogError("Counter Text not assigned in the Inspector");
        }
    }
    //show the win game screen and freeze the game
    private void WinGame()
    {
        winText.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
    //restart the game and unfreeze
    public void RestartTime()
    {
        Time.timeScale = 1f;
    }
    //if the game is freezing, click r to restart
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



}
