using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public bool paused = false;

    private void Awake()
    {
        paused = false;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.F1))
        {
            LoadScene(0);
        }
        if (Input.GetKey("escape"))
        {
            ExitGame();
        }

        if (Input.GetKey(KeyCode.P))
        {
            if (paused == false)
            {
                Time.timeScale = 0;
                paused = true;
            }
            else
            {
                Time.timeScale = 1;
                paused = false;
            }
        }

    }
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void ExitGame()
    {
        Application.Quit();
    }

}
