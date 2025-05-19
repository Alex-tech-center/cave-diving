using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayerOnCollision : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger entered by: " + collision.name);

        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player hit! Restarting...");
            GameManager.instance.Restart();
        }
    }
}
