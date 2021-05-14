using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public void PrologueScene()
    {
        Debug.Log("Load prologue");
        SceneManager.LoadScene("SampleScene");
    }

    public void MenuScene()
    {
        Debug.Log("Load menu");
        SceneManager.LoadScene("TitleScreen");
    }

    public void ExitGame()
    {
        Debug.Log("Close game");
        Application.Quit();
    }
}
