using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
  

    public static GameStates menuState;
    

    public GameObject postGameUI;
    public bool paused = false;
    public static Menu menu;

    private void Awake()
    {
        paused = false;
        if (menu == null)
        {
            menu = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        menuState = GameStates.Game;
    }
    void Update()
    {


    }
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void PostGame()
    {
        if (postGameUI != null)
        {
            postGameUI.SetActive(true);
            menuState = GameStates.PostGame;

        }
    }

    private void OnDestroy()
    {
        if (menu == this)
        {
            menu = null;
        }
    }
}
public enum GameStates
{
    Game,
    PostGame
}