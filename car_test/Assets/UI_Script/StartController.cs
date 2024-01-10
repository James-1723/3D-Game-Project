using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartController : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Image was clicked! Switching to Game Scene...");

        // Switch to the "Game" scene
        Invoke("SwitchToTrailer",1.5f);
    }

    private void SwitchToTrailer()
    {
        // Define the name of the scene
        string gameSceneName = "Trailer";

        // Use SceneManager.LoadScene to switch to the specified scene
        SceneManager.LoadScene(gameSceneName);
    }

    
}