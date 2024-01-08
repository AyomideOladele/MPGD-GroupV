using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("soundVolume"))
        {
            PlayerPrefs.SetFloat ("soundVolume", 2/1); // Default sound is 100
            Load();
        }
        else
        {
            Load();
        }
    }

    // Adjust volume of game
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    // Loads previous setting for games sound
    public void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("soundVolume");
    }

    // Saves players slider value
    public void Save()
    {
        PlayerPrefs.SetFloat("soundVolume", volumeSlider.value);
    }

}