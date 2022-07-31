/*
 Copyright (c) Józef Yika
*/


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Level2_MovementControlNonStatic : MonoBehaviour
{
    #region Variables


    private Vector2 targetPos;
    public float XIncrement;

    public float velocity;
    public float speed;

    public float maximumX_Positive;
    public float minimumX_Negative;

    public float fallTime = 0.8f;

    public float respawnTime = 4.0f;

    private Level2_SpawnerNonStatic _spawner;

    private ChangeIntervalText changeIntervalText;


    private Level2_SpawnerStatic checkPoint; // static note check point - a reference to the static note 

    public float distanceBtwTwoNotes; // distance between two notes 

    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
       
        _spawner = FindObjectOfType<Level2_SpawnerNonStatic>();
        changeIntervalText = FindObjectOfType<ChangeIntervalText>();
        checkPoint = FindObjectOfType<Level2_SpawnerStatic>();
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        var moved = false;

        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maximumX_Positive)
        {
            targetPos = new Vector2(transform.position.x + XIncrement, transform.position.y);
            transform.position = targetPos;
            moved = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minimumX_Negative)
        {
            targetPos = new Vector2(transform.position.x - XIncrement, transform.position.y);
            transform.position = targetPos;
            moved = true;
        }


        if (moved)
        {
            _spawner.DestroyNote();
            var note = GenericScript.CalculateNoteNameFromPosition(transform.position.x, "Sharp");
            _spawner.ReplaceExistingNote(note, transform.position);

            distanceBtwTwoNotes = (checkPoint.Note.transform.position.x - transform.position.x); // calculate the actual distancec between two notes 
            Debug.Log("Distance : " + distanceBtwTwoNotes.ToString("F1") + "units"); // log into console !
            if (distanceBtwTwoNotes <= -4 && distanceBtwTwoNotes >= 4) // 2nd Interval : Major and Minor - if the distance is less than -5  or less than 5( -x, x axis) 
            {
                ScoreBoardStatic.IncrementPoints(); // add a point 
                Debug.Log("POOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOINTS : " + ScoreBoardStatic.ScoreAPoint.ToString());
            }
            else
            {
                ScoreBoardStatic.DecrementPoints();
            }


        }



       
    }

    void OnTriggerEnter2D(Collider2D pianoKey)
    {
        if (pianoKey.CompareTagsExtension())
        {
            _spawner.DestroyNote();
            
         //   Debug.Log("NON STATIC : NOTE DESTROYED"); 
            _spawner.GenerateNewNote();
        }
        changeIntervalText.GenerateNewIntervalOnTheScreen();
        

    }

   

    #endregion
}