using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class En_Movement : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del enemigo

    void Update()
    {
        // Mover hacia atrás en la dirección opuesta al frente del enemigo
        transform.Translate(-Vector3.back * speed * Time.deltaTime);
    }
}
