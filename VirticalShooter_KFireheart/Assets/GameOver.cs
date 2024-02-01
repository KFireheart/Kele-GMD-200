using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static bool GameIsOver;

    public GameObject gameOverUI;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }
}
