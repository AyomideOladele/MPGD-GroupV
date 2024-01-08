using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoorInteraction : MonoBehaviour
{
    public string School; // Name of the scene you want to transition to
    public GameObject promptText; // Reference to the Text element displaying the prompt

    private bool canInteract = false;

    private void Update()
    {
        // Check if the player is in front of the door (you can use colliders for this)
        // For example, if the player's collider enters the door's trigger collider

        if (canInteract)
        {
            // Display the prompt text
            promptText.SetActive(true);

            // Check if the player presses the "E" key
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Load the target scene
                SceneManager.LoadScene(School);
            }
        }
        else
        {
            // Hide the prompt text
            promptText.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canInteract = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canInteract = false;
        }
    }
}

