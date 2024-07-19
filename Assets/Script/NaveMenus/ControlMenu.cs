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
        if (OptionsMenu != null) OptionsMenu.SetActive(false);
        if (How != null) How.SetActive(false);
        if (MainMenu != null) MainMenu.SetActive(true);
    }

    public void OnClickOptions()
    {
        if (MainMenu != null) MainMenu.SetActive(false);
        if (OptionsMenu != null) OptionsMenu.SetActive(true);
        AudioSettings();
    }

    public void OnClickHow()
    {
        if (MainMenu != null) MainMenu.SetActive(false);
        if (OptionsMenu != null) OptionsMenu.SetActive(false);
        if (How != null) How.SetActive(true);
    }

    public void AudioSettings()
    {
        if (AudioPanel != null) AudioPanel.SetActive(true);
        if (DisplayPanel != null) DisplayPanel.SetActive(false);
    }

    public void DisplaySettings()
    {
        if (AudioPanel != null) AudioPanel.SetActive(false);
        if (DisplayPanel != null) DisplayPanel.SetActive(true);
    }

    void Start()
    {
        if (MainMenu != null) MainMenu.SetActive(true);
        if (OptionsMenu != null) OptionsMenu.SetActive(false);
        if (How != null) How.SetActive(false);
        if (AudioPanel != null) AudioPanel.SetActive(false);
        if (DisplayPanel != null) DisplayPanel.SetActive(false);
    }
}



