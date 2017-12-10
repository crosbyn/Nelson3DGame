using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{

    public void StartGameButtonClicked()
    {
        //Load the next scene
        SceneManager.LoadScene("Scene1");
    }

    public void CreditsButtonClicked()
    {
        //Load the next scene
        SceneManager.LoadScene("CreditsScene");
    }


    public void QuitButtonClicked()
    {
        Application.Quit();
    }
}
