using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightSpawner : MonoBehaviour
{
    public GameObject[] animalPrefabs1;
    

    private float spawnRangeX1 = 20;
    private float spawnRangeZ1 = 20;

    private float spawnPosZ1= 20;
    private float spawnPosX1 = 20;
    private float startDelay = 2;
    
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
         InvokeRepeating("LeftEnemySpawner", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
   
    void  LeftEnemySpawner() {
            int animalIndex = Random.Range(0, animalPrefabs1.Length);
            Vector3 spawnPos1 = new Vector3(spawnPosX1,
            0, Random.Range(-spawnRangeZ1, spawnRangeZ1));
            Instantiate(animalPrefabs1[animalIndex], spawnPos1,
            animalPrefabs1[animalIndex].transform.rotation = Quaternion.Euler(0, -90, 0));
        
    } 
}
