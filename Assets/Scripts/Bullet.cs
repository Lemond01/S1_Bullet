using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bala;
    public float speed;
    public float destroy;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            Debug.Log("Disparando");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            GameObject bullet = Instantiate(bala) as GameObject;
            
            bullet.AddComponent<Rigidbody>();
            bullet.GetComponent<Rigidbody>().mass = 1;
            bullet.GetComponent<Rigidbody>().AddForce(ray.direction * speed);

            bullet.AddComponent<BoxCollider>();
            bullet.AddComponent<Spawn>();

            Destroy(bullet, 3.0f);
        }
    }
}
