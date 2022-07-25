/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScorePoint : MonoBehaviour
{
    #region Variables
    public TextMeshProUGUI Interval;
    public List<string> intervalList;
    #endregion

    #region Unity Methods
	
    // Start is called before the first frame update
    void Start()
    {

        intervalList = new List<string>();
        intervalList.Add("Minor 2nd");
        intervalList.Add("Major 2nd");
        intervalList.Add("Minor 3rd");
        intervalList.Add("Major 3rd");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeIntervalText()
    {

        Interval.text = intervalList[Random.Range(0, 3)];
    }

    
   

    #endregion
}
