using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class En_Spawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Transform player;
    public float spawnDistance = 20f;
    public float spawnInterval = 3f;
    public int[] enemyCounts;

    private void Start()
    {
        if (enemyPrefabs.Length != enemyCounts.Length)
        {
            Debug.LogError("El número de enemigos y las cantidades no coinciden.");
            return;
        }
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnEnemy()
    {
        int totalEnemies = 0;
        foreach (int count in enemyCounts)
        {
            totalEnemies += count;
        }

        int randomIndex = Random.Range(0, totalEnemies);
        int enemyType = 0;

        int accumulated = 0;
        for (int i = 0; i < enemyCounts.Length; i++)
        {
            accumulated += enemyCounts[i];
            if (randomIndex < accumulated)
            {
                enemyType = i;
                break;
            }
        }

        Vector3 spawnPosition = player.position + (player.forward * spawnDistance) + new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f));
        Quaternion spawnRotation = Quaternion.LookRotation(-player.forward);

        Instantiate(enemyPrefabs[enemyType], spawnPosition, spawnRotation);
    }
}
