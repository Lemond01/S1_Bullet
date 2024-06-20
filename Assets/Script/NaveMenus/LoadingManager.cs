using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider progressBar;
    public string sceneToLoad;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        progressBar.onValueChanged.AddListener(delegate { SliderValueChanged(); });
    }

    private void SliderValueChanged()
    {
        if (progressBar.value == 1f)
        {
            LoadGameScene();
        }
    }

    public void LoadGameScene()
    {
        StartCoroutine(LoadSceneAsync(sceneToLoad));
    }

    IEnumerator LoadSceneAsync(string sceneName)
    {
        loadingScreen.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);

        operation.allowSceneActivation = false;


        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            if (progressBar != null)
            {
                progressBar.value = progress;
            }

            if (operation.progress >= 0.9f)
            {
                yield return new WaitForSeconds(1f);

                operation.allowSceneActivation = true;

                while (!operation.isDone)
                {
                    yield return null;
                }

                loadingScreen.SetActive(false);
            }

            yield return null;
        }
    }
}


