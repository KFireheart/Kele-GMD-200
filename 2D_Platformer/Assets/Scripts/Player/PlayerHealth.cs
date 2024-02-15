using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHeath;
    public float health;
    public Image heathBar;
    [SerializeField] public GameOverScript gameOverScript;

    GameOverScript gameIsOver;


    private void Start()
    {
        maxHeath = health;
       
    }


    private void Update()
    {
        heathBar.fillAmount = Mathf.Clamp(health / maxHeath, 0, 1);

        if(health <= 0)
        {
            gameOverScript.gameOver();
        }
    }
}
