using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Simple : MonoBehaviour
{
    public float speed = 5f;
    public float verticalSpeed = 5f;
    public float forwardSpeed = 10f;

    public GameObject bulletPrefab;
    public Transform firePoint;
    private CharacterController controller;

    private bool isShooting = false;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, vertical, 1f).normalized;

        if (direction.magnitude >= 0.1f)
        {
            Vector3 move = new Vector3(horizontal * speed, vertical * verticalSpeed, forwardSpeed) * Time.deltaTime;
            controller.Move(move);
        }

        if (Input.GetMouseButtonDown(0))
        {
            isShooting = true;
            StartCoroutine(ShootContinuously());
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isShooting = false;
        }
    }

    IEnumerator ShootContinuously()
    {
        while (isShooting)
        {
            Shoot();
            yield return new WaitForSeconds(0.5f);
        }
    }

    void Shoot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, firePoint.position);
        float distance;

        if (plane.Raycast(ray, out distance))
        {
            Vector3 targetPoint = ray.GetPoint(distance);
            Vector3 direction = (targetPoint - firePoint.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(direction);
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, rotation);
            bullet.GetComponent<Rigidbody>().velocity = direction * bullet.GetComponent<Bullet_Normal>().speed;

            Destroy(bullet, 3f);
        }
    }
}


