using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class En_Bullet : MonoBehaviour
{
    public GameObject enemyProjectilePrefab;
    public Transform firePoint; // El punto desde donde se disparará el proyectil
    public float fireRate = 1f; // Proyectiles por segundo
    private float nextFireTime = 2f;
    private Transform player; // Referencia al jugador

    void Start()
    {
        // Buscar al jugador por su tag
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            player = playerObject.transform;
        }
    }

    void Update()
    {
        if (player != null && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    void Shoot()
    {
        // Crear el proyectil y ajustar su rotación para que apunte al jugador
        GameObject projectile = Instantiate(enemyProjectilePrefab, firePoint.position, firePoint.rotation);
        projectile.transform.rotation = Quaternion.LookRotation(player.position - firePoint.position);
    }
}
