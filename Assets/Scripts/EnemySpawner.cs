using UnityEngine;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    public Transform player;
    public float spawnRadius = 12f;
    public List<GameObject> enemyPrefabs;

    public float spawnInterval = 2f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        Vector2 spawnPos = (Vector2)player.position + Random.insideUnitCircle.normalized * spawnRadius;
        GameObject prefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Count)];
        Instantiate(prefab, spawnPos, Quaternion.identity);
    }
}
