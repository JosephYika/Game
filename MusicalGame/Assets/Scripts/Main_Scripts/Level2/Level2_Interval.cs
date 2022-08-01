/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Level2_Interval : MonoBehaviour
{
    
    public GenericScript.Interval intervalEnum;

    public TextMeshProUGUI IntervalText;
    
    public Level2_SpawnerStatic noteReference;

    private System.Random rand;




    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        rand = new System.Random();
       
        noteReference = FindObjectOfType<Level2_SpawnerStatic>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GenerateNewIntervalOnTheScreen()
    {
        // Adding boundaries - if the spawned notes are C and C# generate only Minor 2nd or Major Second Interval UP , not down. There is not enough space to build it down..
        // Accordingly If its B or A Sharp then an Interval will only indacte to build it down. 

        if (noteReference.Note.tag == "C")
        {

            List<GenericScript.Interval> intervals = new List<GenericScript.Interval>();
            intervals.Add(GenericScript.Interval.MajorSecondUp);
            intervals.Add(GenericScript.Interval.MinorSecondUp);

            var intervalPick = Random.Range(0, intervals.Count);
            intervalEnum = intervals[intervalPick];
           
           
        }
        else if(noteReference.Note.tag == "CSharp")
        {
            List<GenericScript.Interval> intervals = new List<GenericScript.Interval>();
            intervals.Add(GenericScript.Interval.MajorSecondUp);
            intervals.Add(GenericScript.Interval.MinorSecondUp);
            intervals.Add(GenericScript.Interval.MinorSecondDown);

            var intervalPick = Random.Range(0, intervals.Count);
            intervalEnum = intervals[intervalPick];

        }

        
        IntervalText.text = GenericScript.IntervalChange(intervalEnum);
    }


    #endregion
}
