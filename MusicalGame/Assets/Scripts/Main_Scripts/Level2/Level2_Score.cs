/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Level2_Score : MonoBehaviour
{
    #region Variables
    public TextMeshProUGUI scoreOnTheScreen;
    public Level2_SpawnerNonStatic noteNoneStatic;
    public Level2_SpawnerStatic noteStatic;
    public ChangeIntervalText checkIntervalText;
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        noteNoneStatic = FindObjectOfType<Level2_SpawnerNonStatic>();
        noteStatic = FindObjectOfType<Level2_SpawnerStatic>();
        checkIntervalText = FindObjectOfType<ChangeIntervalText>();
        ScoreBoardStatic.ResetPoints();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D note)
    {
        
        float distance = Vector2.Distance(noteNoneStatic.transform.position, noteStatic.transform.position);
        if (note.CompareTagsExtension() &&  distance < -3)
        {
            
            ScoreBoardStatic.IncrementPoints();
            scoreOnTheScreen.text = ScoreBoardStatic.ScoreAPoint.ToString();
        }
    }

    #endregion
}
