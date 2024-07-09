using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScrip : MonoBehaviour
{
    [SerializeField] private GameObject gameOverObj;

    [SerializeField] AudioClip explotion;

    private AudioSource audioSource;


    [SerializeField] private float vida;
    [SerializeField] private float maximoVida;

    [SerializeField] private barradevida barradevida;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Time.timeScale = 1.0f;
        vida = maximoVida;
        barradevida.InicializarBarraDeVida(vida);
    }

    public void TomarDaño(float daño)
    {
        vida -= daño;
        barradevida.CambiarVidaActual(vida);
        if (vida <= 0)
        {
            gameOverObj.SetActive(true);
            Time.timeScale = 0;
            audioSource.PlayOneShot(explotion);
            Destroy(gameObject);
        }
    }

    public void Curar(float curacion)
    {
        if((vida + curacion) > maximoVida)
        {
            vida = maximoVida;
        }
        else
        {
            vida += curacion;
        }
        barradevida.CambiarVidaActual(vida);
    }

}
