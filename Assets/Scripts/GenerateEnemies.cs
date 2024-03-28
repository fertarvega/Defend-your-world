using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float minY = -2f;
    public float maxY = 2f;
    public float frequency = 3f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, frequency);
    }

    void SpawnEnemy()
    {
        float randomY = Random.Range(minY, maxY);

        Instantiate(enemyPrefab, new Vector3(transform.position.x, randomY, transform.position.z), Quaternion.identity);
    }
}

