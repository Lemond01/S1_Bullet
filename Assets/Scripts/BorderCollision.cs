using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.CompareTag("Player"))
        {
            Debug.Log("El " + other.gameObject.name + " esta chocando con un muro");
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.collider.CompareTag("Player"))
        {
            Debug.Log("El " + other.gameObject.name + " dejo el muro");
        }
    }
}
