/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    #region Variables
    public AudioSource playPopSound;
    public AudioSource playPianoMusic;
    #endregion

    #region Unity Methods
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SceneTransitionOnTrigger();
    }

    public void SceneTransitionOnTrigger()
    {
        // SCENE 0
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene0"))
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                SceneManager.LoadScene("TutorialScene1");
                playPopSound.Play();
            }



        }
        // SCENE 1
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene1"))
        {
            
            
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene2");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene0");
            }

        }
        // SCENE 2
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene2"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene3");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene1");
            }

        }

        // SCENE 3
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene3"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene4");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene2");
            }

        }

        // SCENE 4

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene4"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene5");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene3");
            }

        }

        // SCENE 5

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene5"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene6");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene4");
            }

        }

        // SCENE 6 

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene6"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene7");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene5");
            }

        }

        // SCENE 7 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene7"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene8");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene6");
            }

        }

        // SCENE 8
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene8"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene9");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene7");
            }

        }

        // SCENE 9 

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene9"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene10");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene8");
            }

        }

        // SCENE 10 

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene10"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene11");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene9");
            }

        }

        // SCENE 11 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene11"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene12");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene10");
            }

        }

        // SCENE 12 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene12"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene13");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene11");
            }

        }

        // SCENE 13 

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene13"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene14");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene12");
            }

        }

        // SCENE 14 

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene14"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene15");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene13");
            }

        }

        // SCENE 15 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene15"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene16");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene14");
            }

        }

        // SCENE 16 
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene16"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                SceneManager.LoadScene("TutorialScene17");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene15");
            }

        }

        // SCENE 17 

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("TutorialScene17"))
        {

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playPopSound.Play();
                playPianoMusic.Play();
                SceneManager.LoadScene("Level1_IntermediaryModeWhite");
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("TutorialScene16");
            }

        }
    }
    #endregion
}
