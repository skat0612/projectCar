using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyObject;
    private float spawnRange = 9;
    private int enemyCount;
    public int waveNumder = 1;
    //public GameObject powerUp;
    // Start is called before the first frame update
    void Start()
    {


        SpawnEnemyWave(waveNumder);
        //Instantiate(powerUp, GenerateSpawnPosition(), powerUp.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<CarAI>().Length;
        if (enemyCount == 0)
        {
            waveNumder++;
            SpawnEnemyWave(waveNumder);
            //Instantiate(powerUp, GenerateSpawnPosition(), powerUp.transform.rotation);
        }
    }

    Vector3 GenerateSpawnPosition()
    {
        float spawnx = Random.Range(-spawnRange, spawnRange);
        float spawnz = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnx, 0, spawnz);
        return randomPos;

    }



    void SpawnEnemyWave(int enemyToSpawn)
    {
        for (int i = 0; i < enemyToSpawn; i++)
        {
            Instantiate(enemyObject, GenerateSpawnPosition(), enemyObject.transform.rotation);
        }

    }


}
