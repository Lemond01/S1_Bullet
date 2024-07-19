using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class En_Spawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs; // Array para los prefabs de los enemigos
    public Transform player; // Referencia al jugador
    public float spawnDistance = 20f; // Distancia al frente del jugador donde aparecerán los enemigos
    public float spawnInterval = 3f; // Intervalo entre apariciones
    public int[] enemyCounts; // Cantidad de cada tipo de enemigo

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
        // Elegir un tipo de enemigo aleatorio basado en las cantidades
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

        // Crear una posición aleatoria al frente del jugador
        Vector3 spawnPosition = player.position + (player.forward * spawnDistance) + new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f));

        // Ajustar la rotación para que miren hacia el jugador
        Quaternion spawnRotation = Quaternion.LookRotation(-player.forward);

        // Instanciar el enemigo
        Instantiate(enemyPrefabs[enemyType], spawnPosition, spawnRotation);
    }
}
