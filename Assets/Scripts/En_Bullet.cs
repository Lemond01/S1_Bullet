using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class En_Bullet : MonoBehaviour
{
    public GameObject enemyProjectilePrefab;
    public Transform firePoint; 
    public float fireRate = 1f;
    private float nextFireTime = 2f;
    private Transform player; 

    void Start()
    {
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
        GameObject projectile = Instantiate(enemyProjectilePrefab, firePoint.position, firePoint.rotation);
        projectile.transform.rotation = Quaternion.LookRotation(player.position - firePoint.position);
    }
}
