using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        StartCoroutine(Co_SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Co_SpawnEnemies()
    {
        while (true)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2.0f);

            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1.0f);
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
    }
}
