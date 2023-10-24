using MoreMountains.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Oleadas : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] MMPath pathToUse;
    [SerializeField] Transform spawnPoint;

    public float timeBetweenWaves;
    public float timeBetweenSpawns;
    public List<Wave> waves;

    int currentWave = 0;
    float waveTimer = 0;

    float spawnTimer;
    int currentSpawnCount;

    bool canSpawn = false;
    bool isCurrentWaveFinished = false;

    void Awake()
    {
        canSpawn = true;
    }

    void Update()
    {
        if (!canSpawn) return;
        
        if(isCurrentWaveFinished )
        {
            if (currentWave + 1 >= waves.Count)
            {
                canSpawn = false;
                return;
            }
            waveTimer += Time.deltaTime;
            if (waveTimer > timeBetweenWaves)
            {
                NextWave();
                waveTimer = 0;
                isCurrentWaveFinished = false;
            }
        }
        else
        {
            if (currentWave < waves.Count)
            {
                SpawnCurrentWave();
            }
        }


    }

    void SpawnCurrentWave()
    {
        if(spawnTimer > timeBetweenSpawns)
        {
            GameObject enemy = Instantiate(enemyPrefab);
            MMPath path = enemy.GetComponent<MMPath>();
            path.ReferenceMMPath = pathToUse;
            spawnTimer = 0;
            currentSpawnCount++;
            if (currentSpawnCount >= waves[currentWave].numberOfEnemies) isCurrentWaveFinished = true;
        }
        else
        {
            spawnTimer += Time.deltaTime;
        }
    }

    void NextWave()
    {
        currentWave++;
        currentSpawnCount = 0;

    }
}

[System.Serializable]
public class Wave
{
    public int numberOfEnemies;
}