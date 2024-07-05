using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject UIpause;
    public GameObject UIoptions;
    public GameObject AudioPanel;
    public GameObject DisplayPanel;

    
    private bool isPaused = false;

    void Start()
    {
        UIpause.SetActive(false);
        UIoptions.SetActive(false);
    }

    public void CloseOptions()
    {
        UIoptions.SetActive(false);
        UIpause.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                if (UIoptions.activeSelf)
                {
                    CloseOptions();
                }
                else
                {
                    Resume();
                }
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
        UIoptions.SetActive(false);
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
        Time.timeScale = 0f;
        isPaused = true;

        /* 
        AudioSource[] sounds = FindObjectsOfType<AudioSource>();
        for (int i = 0; i < sounds.Length; i++)
        {
            sounds[i].Pause();
        }
        */

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void LoadOptions()
    {
        UIpause.SetActive(false);
        UIoptions.SetActive(true);
        AudioSettings();        
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void AudioSettings()
    {
        AudioPanel.SetActive(true);
        DisplayPanel.SetActive(false);
    }

    public void DisplaySettings()
    {
        AudioPanel.SetActive(false);
        DisplayPanel.SetActive(true);
    }
}
