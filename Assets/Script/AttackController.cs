using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] float shootingInterval = 0.5f; 

    private bool isShooting = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isShooting)
            {
                StartCoroutine(ShootContinuously());
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isShooting = false;
        }
    }

    IEnumerator ShootContinuously()
    {
        isShooting = true;

        while (isShooting)
        {
            Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(shootingInterval);
        }
    }
}
