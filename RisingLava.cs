using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // This is needed to restart the game

public class RisingLava : MonoBehaviour
{
    // How fast the lava moves up. Try 0.5 or 1.0.
    public float riseSpeed = 0.5f;

    void Update()
    {
        // This moves the object Up every frame
        transform.Translate(Vector3.up * riseSpeed * Time.deltaTime);
    }

    // This checks if something enters the "Trigger" area
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that touched the lava is named "Player"
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Game Over! Restarting...");

            // This restarts the current level
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}