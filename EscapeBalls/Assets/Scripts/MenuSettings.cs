﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSettings : MonoBehaviour
{
    public void PlayGame() {

        SceneManager.LoadScene("GamePlay");

    }
    public void QuitGame() {
        Application.Quit();
    }

}
