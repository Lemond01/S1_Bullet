using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Normal : MonoBehaviour
{
    public float speed = 20.0f;
    
    void Start()
    {
       
    }

    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

}
