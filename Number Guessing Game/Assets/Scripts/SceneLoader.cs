using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SceneLoader : MonoBehaviour
{
    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadExplanation()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadWinScene()
    {
        SceneManager.LoadScene(3);
    }


}
