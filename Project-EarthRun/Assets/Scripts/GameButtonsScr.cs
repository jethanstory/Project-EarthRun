using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtonsScr : MonoBehaviour
{
    // Start is called before the first frame update
    public void ReplayGame()
    {
        SceneManager.LoadScene("TestScene"); //SceneManager.LoadScene("Forest");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame() 
    {
        //SceneManager.LoadScene("LoadingScene"); //SceneManager.LoadScene("Forest");
        SceneManager.LoadScene("TestScene");
    }
    public void CreditScene() 
    {
        //SceneManager.LoadScene("LoadingScene"); //SceneManager.LoadScene("Forest");
        SceneManager.LoadScene("CreditsScene");
    }

    public void MainMenuScene() 
    {
        SceneManager.LoadScene("MainMenu"); //SceneManager.LoadScene("Forest");
    }
}
