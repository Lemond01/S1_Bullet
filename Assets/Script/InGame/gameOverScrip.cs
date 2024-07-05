using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverScrip : MonoBehaviour
{
   

    public void GoMenu(string menuText)
    {
        SceneManager.LoadScene(menuText);
        
    }

    public void Reanure(string reanureText)
    {
        SceneManager.LoadScene(reanureText);

    }
}
