using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void StartGame(string sceneName)
    {
        Debug.Log("start");
        SceneManager.LoadScene(sceneName);
    }
    public void Exit()
    {
        Debug.Log("exit");
        Application.Quit();
    }
}
