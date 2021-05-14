﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void FlyAgain()
    {
        SceneManager.LoadScene(2);
    }
    public void MManu()
    {
        SceneManager.LoadScene(0);
    }
}
