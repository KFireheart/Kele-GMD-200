using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    //sets a bullet liftime
    private void Start()
    {
        Invoke("DestroyBullet", 1f);
    }

    //Destroys the bullet
    void DestroyBullet()
    {
        Destroy(gameObject);
    }

    //Destroys bullet on collision with anything that has a collison
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<EnemyManager>(out EnemyManager enemyComponent)) 
        {
            enemyComponent.takeDamage(1);

        }

        Destroy(gameObject);
    }
}
