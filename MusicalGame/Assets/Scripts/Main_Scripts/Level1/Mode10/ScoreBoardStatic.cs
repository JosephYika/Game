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
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_IntermediaryModeWhite") && scoreAPoint == 2)
        {
           
                SceneManager.LoadScene("Level1_Mode1");
            
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1_Mode1") && scoreAPoint == 2)
        {

            SceneManager.LoadScene("Level1_Mode2");

        }

    }
    
   


    #endregion
}
