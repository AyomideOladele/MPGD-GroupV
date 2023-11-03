using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject ON;
    public GameObject OFF;
    private bool IsON;


    // Start is called before the first frame update
    void Start()
    {
        ON.SetActive(false);
        OFF.SetActive(true);
        IsON = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if (IsON)
            {
                ON.SetActive(false);
                OFF.SetActive(true);
            }
            if (!IsON)
            {
                ON.SetActive(true);
                OFF.SetActive(false);
            }
            IsON =!IsON;
        }
    }
}
