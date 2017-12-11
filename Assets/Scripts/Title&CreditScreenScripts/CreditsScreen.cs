using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScreen : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }


    public void MainMenuButtonClicked()
    {
        //Load the next scene
        SceneManager.LoadScene("TitleScene");
    }


    public void QuitButtonClicked()
    {
        Application.Quit();
    }
}
