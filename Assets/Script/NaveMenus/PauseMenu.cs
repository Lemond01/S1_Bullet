using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject UIpause;
    public GameObject UIoptions;
    
    private bool isPaused = false;

    void Start()
    {
        UIpause.SetActive(false);
        UIoptions.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        UIpause.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

        AudioSource[] sounds = FindObjectsOfType<AudioSource>();
        for (int i = 0; i < sounds.Length; i++) 
        {
            sounds[i].Play();
        }

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Pause()
    {
        UIpause.SetActive(true);
        UIoptions.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;

        AudioSource[] sounds = FindObjectsOfType<AudioSource>();
        for (int i = 0; i < sounds.Length; i++)
        {
            sounds[i].Pause();
        }

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void LoadOptions()
    {
        UIpause.SetActive(false);
        UIoptions.SetActive(true);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
