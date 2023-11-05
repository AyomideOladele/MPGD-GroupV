using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressKeyPickUpObject : MonoBehaviour
{
    public GameObject Instruction;
    public GameObject ThisTrigger;
    public GameObject ObjectOnGround;
    public GameObject ObjectOnHand;
    public bool Action = false;

    void Start()
    {
        Instruction.SetActive(false);
        ThisTrigger.SetActive(true);
        ObjectOnGround.SetActive(true);
        ObjectOnHand.SetActive(false);

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            if (ObjectOnGround.activeSelf)
            {
                Instruction.SetActive(true);
                Action = true;
            }
            else
            {
                Instruction.SetActive(false);
            }
            
        }
    }

    void OnTriggerExit(Collider collision)
    {
        Instruction.SetActive(false);
        Action = false;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Action)
        {
            if (ObjectOnGround.activeSelf) // Check if the ObjectOnGround is active
            {
                ObjectOnGround.GetComponent<Item>()?.DeactivateAndCount(); // Call the method to deactivate and count
                ObjectOnHand.SetActive(true);
                ThisTrigger.SetActive(false);
                Instruction.SetActive(false);
                Action = false;
            }
        }
    }
}