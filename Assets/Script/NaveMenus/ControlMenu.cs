using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public GameObject How;
    public GameObject AudioPanel;
    public GameObject DisplayPanel;

    public void OnClickReturn()
    {
        OptionsMenu.SetActive(false);
        How.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void OnClickOptions()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(true);
        AudioSettings();
    }

    public void OnClickHow()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(false);
        How.SetActive(true);
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



    void Start()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
        How.SetActive(false);
        AudioPanel.SetActive(false);
        DisplayPanel.SetActive(false);
    }

}


