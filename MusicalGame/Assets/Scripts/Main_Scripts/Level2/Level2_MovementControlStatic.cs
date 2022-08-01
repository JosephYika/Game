/*
 Copyright (c) Józef Yika
*/


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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

    private Level2_SpawnerNonStatic checkPoint; // static note check point - a reference to the static note 

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
            distanceBtwTwoNotes = transform.position.x - checkPoint.Note.transform.position.x; // calculate the actual distancec between two notes 
            Debug.Log("Distance : " + distanceBtwTwoNotes.ToString("F1") + "units"); // log into console !

            if (Math.Abs(distanceBtwTwoNotes) > 4 || distanceBtwTwoNotes == 0)
            {
                Debug.Log("I AM HEREEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE");
                if (ScoreBoardStatic.ScoreAPoint >= 1)
                {
                    ScoreBoardStatic.DecrementPoints();
                }
            }
            else
            {
                Debug.Log("WCHODZIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII");              if (Math.Abs(distanceBtwTwoNotes) == 4 && intervalText.intervalEnum == GenericScript.Interval.MajorSecondUp)
                {
                    ScoreBoardStatic.IncrementPoints();
                    Debug.Log("Point ADDED FOR MAJOR SECOND  UPPPPPPPPPPP W GOREEEE");
                }
                if (distanceBtwTwoNotes == 4 && intervalText.intervalEnum == GenericScript.Interval.MajorSecondDown)
                {
                    ScoreBoardStatic.IncrementPoints();
                    Debug.Log("Point ADDED FOR MAJOR SECOND  DOWNNNNNNNNNNNNNN W DOOLllllllllllllllllllllllllllllll");
                }

                if (distanceBtwTwoNotes == -2 && intervalText.intervalEnum == GenericScript.Interval.MinorSecondUp)
                {
                    ScoreBoardStatic.IncrementPoints();
                    Debug.Log("Point ADDED FOR MINOR SECOND  UPPPPPPPPPPP W GOREEEE");
                }
                if (distanceBtwTwoNotes == 2 && intervalText.intervalEnum == GenericScript.Interval.MinorSecondDown)
                {
                    ScoreBoardStatic.IncrementPoints();
                    Debug.Log("Point ADDED FOR MINOR SECOND  DOWNNNNNNNNNNNNNN W DOOLllllllllllllllllllllllllllllll");
                }


                //ScoreBoardStatic.IncrementPoints(); // add a point 
                //Debug.Log("POOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOINTS : " + ScoreBoardStatic.ScoreAPoint.ToString());
            }

            textScore.scoreText.text = ScoreBoardStatic.ScoreAPoint.ToString();
            _spawner.DestroyKey();

            //   Debug.Log("NON STATIC : NOTE DESTROYED"); 
            _spawner.GenerateNewKey();
        }



    }
    #endregion
}
