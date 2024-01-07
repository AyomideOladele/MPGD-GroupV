using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryManager : MonoBehaviour
{
    public GameObject diaryPage1;
    public GameObject diaryPage2;
    public GameObject diaryPage3;

    public GameManager gameManager;

    public void OpenDiaryPage1()
    {
        diaryPage1.SetActive(true);
        PauseGame();
    }

    public void CloseDiaryPage1()
    {
        diaryPage1.SetActive(false);
        ResumeGame();
    }

    public void OpenDiaryPage2()
    {
        diaryPage2.SetActive(true);
        PauseGame();
    }

    public void CloseDiaryPage2()
    {
        diaryPage2.SetActive(false);
        ResumeGame();
    }

    public void OpenDiaryPage3()
    {
        diaryPage3.SetActive(true);
        PauseGame();
    }

    public void CloseDiaryPage3()
    {
        diaryPage3.SetActive(false);
        gameManager.CheckForWin();
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
