using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float bulletLifetime;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //Shoot Bullet
            GameObject bullet = Instantiate(bulletPrefab,transform.position, transform.rotation);
            //bullet.velocity = Vector2.up * bulletSpeed;
        }
    }
}
