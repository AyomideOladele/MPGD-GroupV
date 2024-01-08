using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public enum Difficulty { Easy, Normal, Hard }
    public static Difficulty currentDifficulty = Difficulty.Normal;

    // Define settings for each difficulty level
    // Walk Speed
    public float easyEnemyWalkSpeed = 1f;
    public float normalEnemyWalkSpeed = 2f;
    public float hardEnemyWalkSpeed = 3f;

    // Chase speed
    public float easyEnemyChaseSpeed = 3f;
    public float normalEnemyChaseSpeed = 4f;
    public float hardEnemyChaseSpeed = 5f;

    // Detection Range
    public float easyEnemyDetectionRange = 5f;
    public float normalEnemyDetectionRange = 10f;
    public float hardEnemyDetectionRange = 15f;


    // Methods to set difficulty
    public void SetDifficulty(Difficulty difficulty)
    {
        currentDifficulty = difficulty;
        SaveDifficulty();
    }

    public void SetEasyDifficulty()
    {
        SetDifficulty(Difficulty.Easy);
    }

    public void SetNormalDifficulty()
    {
        SetDifficulty(Difficulty.Normal);
    }

    public void SetHardDifficulty()
    {
        SetDifficulty(Difficulty.Hard);
    }

    // Saves the set difficulty to PlayerPrefs
    private void SaveDifficulty()
    {
        PlayerPrefs.SetInt("gameDifficulty", (int)currentDifficulty);
        PlayerPrefs.Save();
    }

    // Loads the set difficulty from PlayerPrefs
    private void LoadDifficulty()
    {
        if (PlayerPrefs.HasKey("gameDifficulty"))
        {
            currentDifficulty = (Difficulty)PlayerPrefs.GetInt("gameDifficulty");
        }
    }

    // Method to get settings based on the current difficulty
    public float GetEnemyWalkSpeed()
    {
        switch (currentDifficulty)
        {
            case Difficulty.Easy:
                return easyEnemyWalkSpeed;
            case Difficulty.Normal:
                return normalEnemyWalkSpeed;
            case Difficulty.Hard:
                return hardEnemyWalkSpeed;
            default:
                return normalEnemyWalkSpeed;
        }
    }

    public float GetEnemyChaseSpeed()
    {
        switch (currentDifficulty)
        {
            case Difficulty.Easy:
                return easyEnemyChaseSpeed;
            case Difficulty.Normal:
                return normalEnemyChaseSpeed;
            case Difficulty.Hard:
                return hardEnemyChaseSpeed;
            default:
                return normalEnemyChaseSpeed;
        }
    }

    public float GetEnemyDetectionRange()
    {
        switch (currentDifficulty)
        {
            case Difficulty.Easy:
                return easyEnemyDetectionRange;
            case Difficulty.Normal:
                return normalEnemyDetectionRange;
            case Difficulty.Hard:
                return hardEnemyDetectionRange;
            default:
                return normalEnemyDetectionRange;
        }
    }

    void Start()
    {
        LoadDifficulty(); // Load the difficulty setting at the start of  game
    }
}


    

   

