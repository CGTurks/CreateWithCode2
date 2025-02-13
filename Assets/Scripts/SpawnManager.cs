using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 10; // Horizontal range for top spawns
    private float spawnPosZ = 20; // Z position for top spawns

    private float spawnPosX = 20; // X position for left & right spawns
    private float spawnRangeZ = 10; // Vertical range for left & right spawns

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("TopEnemySpawner", startDelay, spawnInterval);
        InvokeRepeating("LeftEnemySpawner", startDelay, spawnInterval);
        InvokeRepeating("RightEnemySpawner", startDelay, spawnInterval);
    }

    void TopEnemySpawner()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 180, 0));
    }

    void LeftEnemySpawner()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 90, 0)); // Face right
    }

    void RightEnemySpawner()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, -90, 0)); // Face left
    }
}
