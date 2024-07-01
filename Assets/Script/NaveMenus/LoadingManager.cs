using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider SliderBar;

    [Tooltip("Nombre de la escena que se va a cargar")]
    public string NextScene;

    void Start()
    {
        StartCoroutine(LoadAsync(NextScene));
    }

    IEnumerator LoadAsync(string NextScene)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(NextScene);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            SliderBar.value = progress;

            yield return null;


        }
    }
}



