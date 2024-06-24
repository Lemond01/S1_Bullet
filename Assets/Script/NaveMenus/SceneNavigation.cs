using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour
{
    public void OnClickPlay()
    {
        StartCoroutine(LoadSceneWithDelay("Game", 0.0f)); 
    }

    public void OnClickCredits()
    {
        StartCoroutine(LoadSceneWithDelay("Credits", 0.1f)); 
    }

    public void OnClickLoad()
    {
        StartCoroutine(LoadSceneWithDelay("LoadingScene", 2f));
    }
    public void OnClickMenu()
    {
        StartCoroutine(LoadSceneWithDelay("MainMenu", 0.5f)); 
    }

    IEnumerator LoadSceneWithDelay(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay); 
        SceneManager.LoadScene(sceneName);
    }
}

