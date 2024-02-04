using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] float enemyHealth, maxHealth = 3f;


    //Sets enemyHealth equal to maxhealth
    private void Start()
    {
        enemyHealth = maxHealth;
    }

    //subtracts 1 hp point each time enemy gets hit
    public void takeDamage(float damageAmount)
    {
        enemyHealth -= damageAmount;

        if (enemyHealth <= 0)
        { 
            Destroy(gameObject);
        }
    }
}
