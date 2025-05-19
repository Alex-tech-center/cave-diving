using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstactle : MonoBehaviour
{
    public Parallax.Layer layer;

    public float obstacleDistance = 24;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * Parallax.GetSpeed(layer) * Time.deltaTime;

        if (transform.position.y <= -obstacleDistance)
        {
            gameObject.SetActive(false);
        }
    }
}