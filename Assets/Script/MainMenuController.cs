using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuController : MonoBehaviour
{
    public AudioClip ButtonClickEffect;
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component on this game object
        audioSource = GetComponent<AudioSource>();
    }

    public void OnClick()
    {
        // Play the button click sound effect
        audioSource.PlayOneShot(ButtonClickEffect);
    }
    public void PlayGame() {
        
        SceneManager.LoadScene("SampleScene");
    }
    
    
}
