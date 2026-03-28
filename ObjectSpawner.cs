using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // Drag your "Plank" Prefab into this box in the Inspector
    public GameObject plankPrefab;

    // How many seconds between each drop
    public float spawnRate = 2f;

    // How wide is your screen? (Standard is about -8 to 8)
    public float screenWidth = 8f;

    void Start()
    {
        // This tells Unity: "Run the 'Spawn' function every 'spawnRate' seconds"
        InvokeRepeating("Spawn", 1.0f, spawnRate);
    }

    void Spawn()
    {
        // Pick a random X position
        float randomX = Random.Range(-screenWidth, screenWidth);

        // Create the position vector (using the Spawner's height)
        Vector2 spawnPos = new Vector2(randomX, transform.position.y);

        // Create the object!
        Instantiate(plankPrefab, spawnPos, Quaternion.identity);
    }
}