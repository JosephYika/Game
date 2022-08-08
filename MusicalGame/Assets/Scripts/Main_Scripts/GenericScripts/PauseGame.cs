/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    #region Variables

    public static bool isPaused = false;
    public GameObject userInterfacePanel;
    #endregion

    #region Unity Methods
	
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isPaused == true)
            {
                Resume();
            }
            else
            {
                PauseTheGame();
            }
        }
    }



    public void Resume()
    {
        userInterfacePanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void PauseTheGame()
    {
        userInterfacePanel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }


    public void LoadStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    
    #endregion
}
