using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using Unity.VisualScripting;

public class LoadNextScene : MonoBehaviour
{
    public string sceneToLoad;

    //Loads sceneToLoad
   public void LoadLevel()
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
