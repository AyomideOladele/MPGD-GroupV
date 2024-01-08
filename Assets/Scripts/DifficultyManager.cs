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


    // Method to set difficulty
    public void SetDifficulty(Difficulty difficulty)
    {
        currentDifficulty = difficulty;
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
}


    

   

