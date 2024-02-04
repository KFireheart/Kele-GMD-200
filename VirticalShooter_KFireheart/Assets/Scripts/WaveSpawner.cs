using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public enum SpawnState {SPAWNING, WATTING, COUNTING};

    [System.Serializable] 

    //wave class with variables
    public class Wave
    {
        public string name;
        public Transform enemy;
        public int count;
        public float rate;
    }

    public Wave[] waves;
    private int nextWave = 0;

    public Transform[] spawnPoints;

    public float timeBetweenWaves = 5f;
    private float waveCountDown;

    public float searchCountDown = 1f;

    public SpawnState state = SpawnState.COUNTING;


    //
    private void Start()
    {
        if (spawnPoints.Length == 0)
        {
            Debug.Log("No Spawn points referenced");
        }

        waveCountDown = timeBetweenWaves;

    }

    private void Update()
    {
        //Checks to see if the current state = WATTING
        if(state == SpawnState.WATTING)
        {
           
            if (!EnemyIsAlive())
            {
                waveCompleted();
            }
            else
            {

                return;
            }

        }
        //Checks to see if the wave countdown is <= 0, if so start spawing the next wave. Else start the timer again and re check
        if (waveCountDown <= 0)
        {
            if(state != SpawnState.SPAWNING)
            {
                StartCoroutine( SpawnWave ( waves[ nextWave ] ) ); 
            }
        }
        else
        {
            waveCountDown -= Time.deltaTime;
        }
    }

    //Completes the wave and resets timers
    void waveCompleted()
    {
        Debug.Log("Wave complete!");

        state = SpawnState.COUNTING;
        waveCountDown = timeBetweenWaves;

        if(nextWave + 1 > waves.Length - 1)
        {
            nextWave = 0;
            Debug.Log("All waves COMPLETE... Looping");
        }
        else
        {
            nextWave++;
        }

       
    }

    //Checks to see if there are any enemies left, if none returns false
    bool EnemyIsAlive()
    {
        searchCountDown -= Time.deltaTime;
        if(searchCountDown <= 0f)
        {
            

            searchCountDown = 1f;
            if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                return false;
            }
        }
        return true;
    }

    //Runs the SpawnEnemy() function 
    IEnumerator SpawnWave(Wave _wave)
    {
        Debug.Log("Spawning wave" + _wave.name);
        state = SpawnState.SPAWNING;

        for(int i = 0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(1f/_wave.rate);
        }

        state = SpawnState.WATTING;

        yield break;
    }

    //does the spawing of the enemies
    void SpawnEnemy(Transform _enemy)
    {


        if(spawnPoints.Length == 0)
        {
            Debug.Log("No Spawn points referenced");
        }

        Debug.Log("Spawning Enemy:" + _enemy.name);
        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];   
        Instantiate(_enemy, _sp.position, _sp.rotation);

    }
}
