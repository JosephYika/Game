/*
 Copyright (c) Józef Yika
*/


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level2_MovementControlStatic : MonoBehaviour
{
    #region Variables


    private Vector2 targetPos;
    public float XIncrement;

    public float velocity;
    public float speed;

    public float maximumX_Positive;
    public float minimumX_Negative;

    private float previousTime;
    public float fallTime = 0.8f;

    public float respawnTime = 4.0f;

    private Level2_SpawnerStatic _spawner;

   
    private Level2_Interval intervalText;

    private Level2_SpawnerNonStatic checkPoint; // a reference to the non static note

    public float distanceBtwTwoNotes; // distance between two notes 

    private Level2_Score textScore;


    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        
        intervalText = FindObjectOfType<Level2_Interval>();
        _spawner = FindObjectOfType<Level2_SpawnerStatic>();
        intervalText.GenerateNewIntervalOnTheScreen();
        checkPoint = FindObjectOfType<Level2_SpawnerNonStatic>();
        textScore = FindObjectOfType<Level2_Score>();
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        
    }

    void OnTriggerEnter2D(Collider2D pianoKey)
    {

        if (pianoKey.CompareTagsExtension())
        {
            // MINOR AND MAJOR 2NDS
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode1") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode1_Faster"))
            {
                distanceBtwTwoNotes = transform.position.x - checkPoint.notePos; // calculate the actual distancec between two notes
                Debug.Log("Distance : " + distanceBtwTwoNotes.ToString("F1") + "units"); // log into console !

               
                if (distanceBtwTwoNotes == -4 && intervalText.intervalEnum == GenericScript.Interval.MajorSecondUp)
                {
                    ScoreBoardStatic.IncrementPoints();
                    Debug.Log("Point ADDED FOR MAJOR SECOND  UPPPPPPPPPPP W GOREEEE");
                }
                else if (distanceBtwTwoNotes == 4 && intervalText.intervalEnum == GenericScript.Interval.MajorSecondDown)
                {
                    ScoreBoardStatic.IncrementPoints();
                    Debug.Log("Point ADDED FOR MAJOR SECOND  DOWNNNNNNNNNNNNNN W DOOLllllllllllllllllllllllllllllll");

                }

                else if (distanceBtwTwoNotes == -2 && intervalText.intervalEnum == GenericScript.Interval.MinorSecondUp)
                {
                    ScoreBoardStatic.IncrementPoints();
                    Debug.Log("Point ADDED FOR MINOR SECOND  UPPPPPPPPPPP W GOREEEE");
                }
                else if (distanceBtwTwoNotes == 2 && intervalText.intervalEnum == GenericScript.Interval.MinorSecondDown)
                {
                    ScoreBoardStatic.IncrementPoints();
                    Debug.Log("Point ADDED FOR MINOR SECOND  DOWNNNNNNNNNNNNNN W DOOLllllllllllllllllllllllllllllll");
                }
                else if (ScoreBoardStatic.ScoreAPoint >= 1)
                {

                    ScoreBoardStatic.DecrementPoints();

                }
            }
                

            // MINOR AND MAJOR 3RDS
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode2") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode2_Faster"))
            {
                distanceBtwTwoNotes = transform.position.x - checkPoint.notePos; // calculate the actual distancec between two notes
                if (distanceBtwTwoNotes == -8 && intervalText.intervalEnum == GenericScript.Interval.MajorThirdUp)
                {
                    ScoreBoardStatic.IncrementPoints();
                    Debug.Log("Point ADDED FOR MAJOR THIRD  UPPPPPPPPPPP W GOREEEE");
                }
                else if (distanceBtwTwoNotes == 8 && intervalText.intervalEnum == GenericScript.Interval.MajorThirdDown)
                {
                    ScoreBoardStatic.IncrementPoints();
                    Debug.Log("Point ADDED FOR MAJOR THIRD  DOWNNNNNNNNNNNNNN W DOOLllllllllllllllllllllllllllllll");

                }

                else if (distanceBtwTwoNotes == -6 && intervalText.intervalEnum == GenericScript.Interval.MinorThirdUp)
                {
                    ScoreBoardStatic.IncrementPoints();
                    Debug.Log("Point ADDED FOR MINOR THIRD  UPPPPPPPPPPP W GOREEEE");
                }
                else if (distanceBtwTwoNotes == 6 && intervalText.intervalEnum == GenericScript.Interval.MinorThirdDown)
                {
                    ScoreBoardStatic.IncrementPoints();
                    Debug.Log("Point ADDED FOR MINOR THIRD  DOWNNNNNNNNNNNNNN W DOOLllllllllllllllllllllllllllllll");
                }
                else if (ScoreBoardStatic.ScoreAPoint >= 1)
                {

                    ScoreBoardStatic.DecrementPoints();

                }

            }

            // Perfect Fourth 

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode3") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level2_Mode3_Faster"))
            {

                distanceBtwTwoNotes = transform.position.x - checkPoint.notePos; // calculate the actual distancec between two notes
                if (distanceBtwTwoNotes == -10 && intervalText.intervalEnum == GenericScript.Interval.PerfectFourthUp)
                {
                    ScoreBoardStatic.IncrementPoints();
                    Debug.Log("Point ADDED FOR FOURTH  UPPPPPPPPPPP W GOREEEE");
                }
                else if (distanceBtwTwoNotes == 10 && intervalText.intervalEnum == GenericScript.Interval.PerfectFourthDown)
                {
                    ScoreBoardStatic.IncrementPoints();
                    Debug.Log("Point ADDED FOR FOURTH DOWNNNNNNNNNNNNNN W DOOLllllllllllllllllllllllllllllll");

                }
                else if (ScoreBoardStatic.ScoreAPoint >= 1)
                {

                    ScoreBoardStatic.DecrementPoints();

                }
            }

                textScore.scoreText.text = ScoreBoardStatic.ScoreAPoint.ToString();
            _spawner.DestroyKey();

            //   Debug.Log("NON STATIC : NOTE DESTROYED"); 
            _spawner.GenerateNewKey();
        }
        intervalText.GenerateNewIntervalOnTheScreen();


    }
    #endregion
}
