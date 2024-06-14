using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StartRealGame()
    {
        SceneManager.LoadScene(2);
    }

    public void melhoresTempos()
    {
        SceneManager.LoadScene(7);
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }

    public void fechar()
    {
        Application.Quit();
    }

   
}
