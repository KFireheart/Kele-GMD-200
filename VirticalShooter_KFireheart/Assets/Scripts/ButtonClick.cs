using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    //Plays click sound when pressing a button
    public void ClickSound()
    {
        AudioManager.Instance.PlaySFX("Click");
    }
}
