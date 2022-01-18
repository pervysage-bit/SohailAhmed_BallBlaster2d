using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{  
    public GameObject[] ballsPrefab;
    private float xSpawnRange = 9;
    private float ySpawnPos = 5;

    // Start is called before the first frame update
    void Start()
    {    
        InvokeRepeating("SpawnRandomBalls", 2, 4);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomBalls()
    {        
        
         Vector2 spawnPos = new Vector2(-xSpawnRange, ySpawnPos);
         int ballsIndex = Random.Range(0, ballsPrefab.Length);
         Instantiate(ballsPrefab[ballsIndex], spawnPos, ballsPrefab[ballsIndex].transform.rotation);
        
            
    }
}
