using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public GameObject How;

    public void OnClickPlay()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnClickCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void OnClickOptions()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(true);
        How.SetActive(false);
    }

    public void OnClickReturnOp()
    {
        OptionsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }



    public void OnClickHow()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(false);
        How.SetActive(true);
    }

    public void OnClickReturnHow()
    {
        How.SetActive(false);
        MainMenu.SetActive(true);
    }



    void Start()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
        How.SetActive(false);
    }

    void Update()
    {
    }
}


