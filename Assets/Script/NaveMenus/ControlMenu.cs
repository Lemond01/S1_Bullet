using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public GameObject How;

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
        How.SetActive(false);
    }

    public void OnClickHow()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(false);
        How.SetActive(true);
    }

    /*public void OnClickReturnHow()
    {
        How.SetActive(false);
        MainMenu.SetActive(true);
    }
    */



    void Start()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
        How.SetActive(false);
    }

}


