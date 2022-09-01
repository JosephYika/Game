/*
 Copyright (c) Józef Yika
*/
using UnityEngine.SceneManagement;
public static class ScoreBoardStatic
{
    #region Variables
    private static int scoreAPoint;
    public static int ScoreAPoint
    {
        get { return scoreAPoint; }

    }

    #endregion
   
    #region Unity Methods

    public static void  IncrementPoints ()
    {
        scoreAPoint++; 
    }

    public static void DecrementPoints() => scoreAPoint--;

    public static void ResetPoints() => scoreAPoint = 0;


    public static void ChangeScene()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_IntermediaryModeWhite") && scoreAPoint == 3) //15
        {
           
                SceneManager.LoadScene("Level1_Mode1");
            
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode1") && scoreAPoint == 3) //15
        {

            SceneManager.LoadScene("Level1_Mode2");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode2") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode3");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode3") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode4");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode4") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode8_Slow");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode8_Slow") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode8_Faster");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode8_Faster") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode8_Fast");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode8_Fast") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_IntermediaryModeBlack");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_IntermediaryModeBlack") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode5");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode5") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode6");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode6") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode7");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode7") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode9_Slow");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode9_Slow") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode9_Faster");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode9_Faster") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode9_Fast");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode9_Fast") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode10_White_Slow");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode10_White_Slow") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode10_White_Faster");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode10_White_Faster") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode10_Black_Slow");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode10_Black_Slow") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode10_Black_Fast");

        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode10_Black_Fast") && scoreAPoint == 3) //20
        {

            SceneManager.LoadScene("Level1_Mode10");

        }

      

    }




    #endregion
}
