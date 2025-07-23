using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Add this!

public class StartButtonHandler : MonoBehaviour
{
    // Call this from the button's OnClick event
    public void OnStartButtonClicked()
    {
        // Loads the next scene in the build order
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}