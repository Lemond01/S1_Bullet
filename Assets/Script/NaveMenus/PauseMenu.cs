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

        // La música no se reinicia, solo aseguramos que se reanude si estaba pausada
        AudioSource[] sounds = FindObjectsOfType<AudioSource>();
        for (int i = 0; i < sounds.Length; i++)
        {
            if (!sounds[i].isPlaying)
            {
                sounds[i].UnPause(); // Reanudar el audio si estaba pausado
            }
        }

        Cursor.visible = true; // Hacer visible el cursor
        Cursor.lockState = CursorLockMode.None; // No bloquear el cursor
    }

    public void Pause()
    {
        UIpause.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;


        Cursor.visible = true; // Asegurarse de que el cursor sea visible
        Cursor.lockState = CursorLockMode.None; // No bloquear el cursor
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
