using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winner : MonoBehaviour
{
    public string sceneToLoad; // Nombre de la escena a cargar

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Verifica si el objeto que tocó el collider tiene la etiqueta "Player"
        {
            // Cargar la escena especificada
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
