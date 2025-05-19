using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnOnTrigger : MonoBehaviour
{
  private Vector3 startPosition;
    public float respawnDelay = 1.5f;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == this.gameObject)
        {
            return;
        }

        transform.position = startPosition;
    }

    private IEnumerator RespawnAfterDelay()
    {
        gameObject.SetActive(false);

        yield return new WaitForSeconds(respawnDelay);

        transform.position = startPosition;
        gameObject.SetActive(true);
    }
}
