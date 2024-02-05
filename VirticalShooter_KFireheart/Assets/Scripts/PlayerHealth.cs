using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHearts;
    public Sprite emptyHearts;

    public GameOver gameOverScript;

    private bool isDead;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {


        if(health > numOfHearts)
        {
            health = numOfHearts;
        }


        //Checks to see what the current health is and then chnage the visible hearts acordingly
        for (int i = 0; i < hearts.Length; i++) 
        { 
            if(i < health)
            {
                hearts[i].sprite = fullHearts;
            }
            else
            {
                hearts[i].sprite = emptyHearts;
            }


            if(i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        //Checks to see if the player is dead, if isDead = true it runs the game over screen
        if (health <= 0 && !isDead)
        {
            isDead = true;
            gameOverScript.gameOver();
            Debug.Log("Dead");
        }
    }
}
