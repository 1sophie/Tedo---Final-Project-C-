using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
 
    public GameObject plankPrefab;

  
    public float spawnRate = 2f;

  
    public float screenWidth = 8f;

    void Start()
    {
    
        InvokeRepeating("Spawn", 1.0f, spawnRate);
    }

    void Spawn()
    {
     
        float randomX = Random.Range(-screenWidth, screenWidth);

        // Create the position vector (using the Spawner's height)
        Vector2 spawnPos = new Vector2(randomX, transform.position.y);

        // Create the object!
        Instantiate(plankPrefab, spawnPos, Quaternion.identity);
    }
}
