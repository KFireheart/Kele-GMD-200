using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public PlayerMovement playerMovement;
    

    private void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
            
        }

        RotateGun();
       

    }

    private void RotateGun()
    {

    }

    


    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
    }
}
