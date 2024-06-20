using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour
{
    public void OnClickPlay()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnClickCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void OnClickLoad()
    {
        SceneManager.LoadScene("LoadingScene");
    }

    public void OnClickMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
