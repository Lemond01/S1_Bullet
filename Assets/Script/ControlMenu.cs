using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMenu : MonoBehaviour
{

    public GameObject OptionsMenu;
    public void OnClickPlay()
    {
        SceneManager.LoadScene("Game");
    }

    public void OnClickOptions()
    {
        OptionsMenu.SetActive(true);
    }

    public void OnClickReturnOp()
    {
        OptionsMenu.SetActive(false);
    }

    public void OnClickCredits()
    {
        SceneManager.LoadScene("Credits");
    }
    /*
    public void OnClickHow()
    {
        
    }
    */


    // Start is called before the first frame update
    void Start()
    {
        OptionsMenu.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
