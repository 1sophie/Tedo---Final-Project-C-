using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class RisingLava : MonoBehaviour
{
    
    public float riseSpeed = 0.5f;

    void Update()
    {
        
        transform.Translate(Vector3.up * riseSpeed * Time.deltaTime);
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Game Over! Restarting...");

            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
