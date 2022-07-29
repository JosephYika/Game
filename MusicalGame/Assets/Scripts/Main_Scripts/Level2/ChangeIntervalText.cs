/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeIntervalText : MonoBehaviour
{
    #region Variables
    public TextMeshProUGUI Interval;
    public List<string> intervalList;
    public static int generateIntervalsInOrder;
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {

        intervalList = new List<string>();
        intervalList.Add("Minor 2nd <br><sprite=4><br>");
        intervalList.Add("Major 2nd <br><sprite=2><br>");
        intervalList.Add("Minor 2nd <br><sprite=4><br>");
        intervalList.Add("Major 2nd <br><sprite=2><br>");


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GenerateNewIntervalOnTheScreen()
    {

        Interval.text = intervalList[generateIntervalsInOrder++ % intervalList.Count];
    }


    #endregion

}
