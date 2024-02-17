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
        InvokeRepeating("shoot", 1f, 2f);
    }


    //Spawns bullet and plays sfx
    void shoot()
    {
        Instantiate(bulletPrefab, bulletPos.position, Quaternion.identity);
        //AudioManager.Instance.PlaySFX("EnemyPew");
    }
}
