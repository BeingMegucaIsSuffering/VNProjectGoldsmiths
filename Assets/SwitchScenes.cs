using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public void PrologueScene()
    {
        Debug.Log("Load prologue");
        SceneManager.LoadScene("SampleScreen");
    }

    public void MenuScene()
    {
        Debug.Log("Load menu");
        SceneManager.LoadScene("TitleScreen");
    }

    public void MinigameScene()
    {
        Debug.Log("Load minigame");
        SceneManager.LoadScene("MinigameExample");
    }

    public void ExitGame()
    {
        Debug.Log("Close game");
        Application.Quit();
    }
}
