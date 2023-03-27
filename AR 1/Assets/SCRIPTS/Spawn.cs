using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Spawn : MonoBehaviour
{
    public GameObject[] prefabsToSpawn = new GameObject[4];
    public float spawnRate = 10f;
    public float spawnRadius = 1f;
    public int preValue = 0;
    private int spawnIndex = 0;
    
    private float _nextSpawnTime = 4f;
    void Update()
    {
        if (Time.time > _nextSpawnTime)
        {
            SpawnPrefab();
            _nextSpawnTime = Time.time + spawnRate;
            if (GameManager.instance.score < 50)
            {
                spawnRate -= 0.2f;
            }
        }

    }

    private void SpawnPrefab()
    {
        int randomIndex = Random.Range(0, prefabsToSpawn.Length);
        if (preValue != randomIndex)
        {
            Vector2 spawnPosition = transform.position;

            GameObject prefabToSpawn = prefabsToSpawn[randomIndex];
            GameObject spawnedPrefab = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
            preValue = randomIndex;
            Destroy(spawnedPrefab, 10f);
        }
        else
        {
            SpawnPrefab();
        }
    }


}
