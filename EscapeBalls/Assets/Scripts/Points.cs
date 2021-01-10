using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime;

public class Points : MonoBehaviour
{
    public Text punteggio;
    public static float timer=0;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "GamePlay")
        {
            timer = 0;
        }
    }

    private void Update() {
        if (SceneManager.GetActiveScene().name == "GamePlay")
        {
            timer += Time.deltaTime;
            punteggio.text = "Time: " + timer;
        }
        else if (SceneManager.GetActiveScene().name == "Deaths") {

            punteggio.text = "Time: " + Mathf.Round(timer * 1000.0f) * 0.001f;
        }
        
    }

    

}
