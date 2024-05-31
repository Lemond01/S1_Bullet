using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMenu : MonoBehaviour
{
    public void OnClickMenu()
    {
        Debug.Log("para el menu");
        SceneManager.LoadScene("MainMenu");
    }

    void Start()
    {
        Debug.Log("si se inicia");
    }
}
