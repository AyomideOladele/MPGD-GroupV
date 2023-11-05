using UnityEngine;
using UnityEngine.UI; // Use 'using TMPro;' if you're using TextMeshPro

public class GuidelineController : MonoBehaviour
{
    public GameObject guidelinePanel;
    public float displayTime = 10.0f; // Time in seconds to display the guideline

    // Start is called before the first frame update
    void Start()
    {
        // Display the guideline panel
        if (guidelinePanel != null)
        {
            guidelinePanel.SetActive(true);
        }
        // Automatically hide the guideline after a set amount of time
        Invoke("HideGuideline", displayTime);
    }

    // Update is called once per frame
    void Update()
    {
        // Hide the guideline if the user presses the Escape key
        if (Input.GetKeyDown(KeyCode.Escape) && guidelinePanel.activeSelf)
        {
            HideGuideline();
        }
    }

    void HideGuideline()
    {
        // Hide the guideline panel
        if (guidelinePanel != null)
        {
            guidelinePanel.SetActive(false);
        }
    }
}
    