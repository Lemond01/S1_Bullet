using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawn;
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.FindGameObjectWithTag("BulletSpawn");
        transform.position = spawn.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
