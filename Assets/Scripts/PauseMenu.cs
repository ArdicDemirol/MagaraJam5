using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
   

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Pressed");
            if (GameIsPaused)
            {
                Debug.Log("Game continue");
                Resume();
            }
            else
            {
                Debug.Log("Game paused");
                Pause();
            }
        }
    }


    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

        
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }




    public void QuitGame()
    {
        Debug.Log("hjh");
            
        Application.Quit();
    }
}
