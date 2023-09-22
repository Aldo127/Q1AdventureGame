using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("StartScreen");
    }
    public void PlayGame()
    {
        //SceneManager.LoadScene(3);

        // this line loads next scene in order of build :D
        SceneManager.LoadScene("Map");
    }

    public void CreditsMenu()
    {
        SceneManager.LoadScene("CreditsScene");
    }


    public void QuitGame()
    {
        Debug.Log("Quuit");
        Application.Quit();
    }
    public void Story()
    {
        SceneManager.LoadScene("Story");
    }
}
