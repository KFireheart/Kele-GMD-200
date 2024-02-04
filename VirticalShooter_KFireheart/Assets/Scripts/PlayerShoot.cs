using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawn;
    [SerializeField] private float bulletSpeed;
    
    //checks to see if the player has pressed the spacebar, if so shoots a bullet and plays audio
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //Shoot Bullet
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = Vector2.up * bulletSpeed;
            AudioManager.Instance.PlaySFX("Pew");

        }

    }

    
}
