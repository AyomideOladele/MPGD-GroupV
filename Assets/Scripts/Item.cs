using UnityEngine;

public class Item : MonoBehaviour
{
    private bool hasBeenCounted = false;

    // This method is called when the item is picked up and should be deactivated
    public void DeactivateAndCount()
    {
        if (!hasBeenCounted)
        {
            gameObject.SetActive(false); // Deactivate the item
            GameManager.instance.ItemCollected(); // Increment the counter in GameManager
            hasBeenCounted = true; // Mark as counted
        }
    }
}

