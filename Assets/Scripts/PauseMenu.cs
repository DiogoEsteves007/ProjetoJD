using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject scorePanel;
    private bool scorePanelActive; 

    
    public static bool isPaused;
    public void Start()
    {
        pauseMenu.SetActive(false);
        scorePanelActive = scorePanel.activeSelf;

    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused){
                ResumeGame();
            }else{
                PauseGame();
            }
        }
    }

    public void PauseGame(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        scorePanel.SetActive(false);
    }

    public void ResumeGame(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        if (scorePanelActive)
        {
            scorePanel.SetActive(true);
        }
    }

    public void MainMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
