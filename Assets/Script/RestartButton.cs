using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    void Start()
    {
        // Find the Button component attached to this GameObject
        Button restartButton = GetComponent<Button>();
        
        // Add an onclick listener to the Button component, and specify the method to call when the button is clicked
        restartButton.onClick.AddListener(RestartGame);
    }

    void RestartGame()
    {
        // Change the scene to MainMenu
        SceneManager.LoadScene("MainMenu");
    }
}
