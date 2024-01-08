using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryManager : MonoBehaviour
{
    public GameObject diaryPage1;
    public GameObject diaryPage2;
    public GameObject diaryPage3;

    public GameManager gameManager;

    private void Awake()
    {
        // Find the GameManager instance when this object is initialized
        gameManager = GameManager.instance;

        if (gameManager == null)
        {
            Debug.LogError("GameManager not found!");
        }
    }
    public void OpenDiaryPage1()
    {
        diaryPage1.SetActive(true);
    }

    public void CloseDiaryPage1()
    {
        diaryPage1.SetActive(false);
    }

    public void OpenDiaryPage2()
    {
        diaryPage2.SetActive(true);
    }

    public void CloseDiaryPage2()
    {
        diaryPage2.SetActive(false);
    }

    public void OpenDiaryPage3()
    {
        diaryPage3.SetActive(true);
    }

    public void CloseDiaryPage3()
    {
        diaryPage3.SetActive(false);
        if (gameManager != null)
        {
            gameManager.CheckForWin();
        }
        else
        {
            Debug.LogError("GameManager is null when trying to call CheckForWin");
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0f;
    }

    private void ResumeGame()
    {
        Time.timeScale = 1f;
    }

}
