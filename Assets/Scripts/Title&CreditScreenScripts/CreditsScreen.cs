using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScreen : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        audioSource = GetComponent<AudioSource>();
    }


    public void MainMenuButtonClicked()
    {
        //Load the next scene
        audioSource.Play();
        SceneManager.LoadScene("TitleScene");
    }


    public void QuitButtonClicked()
    {
        audioSource.Play();
        Application.Quit();
    }
}
