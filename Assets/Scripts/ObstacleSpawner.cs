using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject planet;
    public float minX, maxX, minY, maxY;
    public float timeInterval;
    private float spawnTime;

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            if (Time.time > spawnTime)
            {
                SpawnPlanet();
                spawnTime = Time.time + timeInterval;
            }
        }
    }

    void SpawnPlanet()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(planet, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
