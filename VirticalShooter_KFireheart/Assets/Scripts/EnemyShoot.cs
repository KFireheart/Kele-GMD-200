using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletPos;
    private float timer;
    private GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shoot", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    { 
       
    }

    void shoot()
    {
        Instantiate(bulletPrefab, bulletPos.position, Quaternion.identity);
    }
}
