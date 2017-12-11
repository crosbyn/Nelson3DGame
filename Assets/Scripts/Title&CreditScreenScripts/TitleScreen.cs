using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void StartGameButtonClicked()
    {
        //Load the next scene
        audioSource.Play();
        SceneManager.LoadScene("Scene1");
    }

    public void CreditsButtonClicked()
    {
        //Load the next scene
        audioSource.Play();
        SceneManager.LoadScene("CreditsScene");
    }


    public void QuitButtonClicked()
    {
        audioSource.Play();
        Application.Quit();
    }
}
