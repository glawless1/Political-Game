using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonHandler : MonoBehaviour
{
    // The name of the scene to load
    [SerializeField] private string nextGameLevel = "NewsLoading";

    // Function for button clicking
    public void OnStartButtonClicked()
    {
        // Load the scene
        Debug.Log("Button Clicked");
        SceneManager.LoadScene(nextGameLevel);
        Debug.Log("Next Scene Loaded");
    }
}