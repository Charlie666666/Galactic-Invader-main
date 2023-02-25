using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenuQuit : MonoBehaviour
{
        void Start()
    {
        // Find the Button component attached to this GameObject
        Button quitButton = GetComponent<Button>();
        
        // Add an onclick listener to the Button component, and specify the method to call when the button is clicked
        quitButton.onClick.AddListener(QuitGame);
    }

    void QuitGame()
    {
        // Quit the game
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}

