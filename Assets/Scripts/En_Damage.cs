using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class En_Damage : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 10;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
        Destroy(gameObject, 3f);
    }

    void OnCollisionEnter(Collision collision)
    {
        Health_Player playerHealth = collision.gameObject.GetComponent<Health_Player>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
