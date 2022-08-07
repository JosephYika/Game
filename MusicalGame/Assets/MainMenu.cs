/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("TutorialScene0");
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level1_IntermediaryModeWhite");
    }
    public void LearnLevel1()
    {
        SceneManager.LoadScene("TutorialScene0");
    }




    public void Basics()
    {
        SceneManager.LoadScene("Level2_Tutorial_Scene0");
    }

    public void SecondInterval()
    {
        SceneManager.LoadScene("Level2_Tutorial_Start2nd");
    }
    public void ThirdInterval()
    {
        SceneManager.LoadScene("Level2_Tutorial_Start3rd");
    }
    public void FourthInterval()
    {
        SceneManager.LoadScene("Level2_Tutorial4th_0");
    }



    public void Load2nd()
    {
        SceneManager.LoadScene("Level2_Tutorial_Scene27");
    }
    public void Load3rd()
    {
        SceneManager.LoadScene("Level2_Tutorial3rd_3");
    }
    public void Load4th()
    {
        SceneManager.LoadScene("Level2_Tutorial4th_6");
    }

    public void LoadChords()
    {
        SceneManager.LoadScene("Level3_Mode0");
    }
}
