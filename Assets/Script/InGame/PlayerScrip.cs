using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScrip : MonoBehaviour
{
    [SerializeField] private GameObject gameOverObj;

    [SerializeField] AudioClip explotion;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Time.timeScale = 1.0f;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            gameOverObj.SetActive(true);
            Time.timeScale = 0;
            audioSource.PlayOneShot(explotion);
          
        }
    }
   
}
