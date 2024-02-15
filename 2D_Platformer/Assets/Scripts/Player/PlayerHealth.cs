using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHeath;
    public float heath;
    public Image heathBar;

    private void Start()
    {
        maxHeath = heath;
    }


    private void Update()
    {
        heathBar.fillAmount = Mathf.Clamp(heath / maxHeath, 0, 1);

        if(heath <= 0)
        {
            Debug.Log("Died");
        }
    }
}
