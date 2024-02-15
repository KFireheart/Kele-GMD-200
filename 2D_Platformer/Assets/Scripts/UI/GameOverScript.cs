using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public GameObject gameOverUI;

    //Runs enables game over menu
    public void gameOver()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }

    //Reloads the current scene
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    //Loads main menu
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

    //Closes application
    public void quit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
