using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Checks to see if the player has hit the escape key, if so run Resume() or Pause() functions
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused) 
            {
                Resume();
            } else
            {
                Pause();
            } 
        }
    }

    //sets time scale = 1 and closes the pause menu
   public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    //Sets timescale = 0, pauses the game, and opens the menu
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    //Closes the game
    public void QuitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
