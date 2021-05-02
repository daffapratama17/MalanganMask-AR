using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void HistoryMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
   public void ChooseMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void PlayAR()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void GoHistory()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ArFaceToMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void ChoosetoAR1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ArFaceToMainMenu2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
    public void ChoosetoAR2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void ArFacetoMainMenu3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }
    public void ChoosetoAR3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
}

