using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed;

    [SerializeField] float destroyTime;
    internal readonly Vector3 speed;

    void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + bulletSpeed * Time.deltaTime, transform.position.y, transform.position.z);
    }

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(destroyTime);

        Destroy(gameObject);
    }
}
