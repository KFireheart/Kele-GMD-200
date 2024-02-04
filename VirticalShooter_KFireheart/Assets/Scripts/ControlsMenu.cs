using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ControlsMenu : MonoBehaviour
{
    public GameObject controlsMenuUI;

    //Makes UI visible
    public void Controls()
    {
       controlsMenuUI.SetActive(true);

    }

    //Makes UI invisible
    public void CloseMenu()
    {
       controlsMenuUI.SetActive(false);
    }
}
