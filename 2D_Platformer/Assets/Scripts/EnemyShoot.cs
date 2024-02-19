using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletPos;
    private float timer;
    private GameObject player;


    //Starts shooting every 1 second, and makes the liftime 2 seconds
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        

        float distance = Vector2.Distance(transform.position, player.transform.position);
        Debug.Log(distance);

        if(distance < 10)
        {
            timer += Time.time;

            if (timer > 10)
            {
                timer = 0;
                

            }
        }

        
    }


    //Spawns bullet and plays sfx
    void shoot()
    {
        Instantiate(bulletPrefab, bulletPos.position, Quaternion.identity);
        //AudioManager.Instance.PlaySFX("EnemyPew");
    }
}
