using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private float respawnY = 10;
    private float respawnX;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        respawnX = transform.position.x;
    }

    public void Respawn()
    {
        gameObject.SetActive(true);
        transform.position = new Vector2 (respawnX, respawnY);
        rb.velocity = Vector2.zero;
    }
    
}
