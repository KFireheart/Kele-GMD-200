using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public string sceneToLoad;

    //Loads sceneToLoad
    public void LoadNext()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToLoad);
    }

    //Closes the application
    public void Quit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
