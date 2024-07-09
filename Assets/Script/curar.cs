using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curar : MonoBehaviour
{
    [SerializeField] private int countVida;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerScrip>().Curar(countVida);

        }
    }
}
