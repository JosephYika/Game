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
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {

        intervalList = new List<string>();
        intervalList.Add("Minor 2nd <br><sprite=4><br>");
        intervalList.Add("Major 2nd <br><sprite=4><br><sprite=2>");
        intervalList.Add("Minor 2nd <br><sprite=4><br><sprite=4>");
        intervalList.Add("Major 2nd <br><sprite=4><br><sprite=2>");


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GenerateNewIntervalOnTheScreen()
    {

        Interval.text = intervalList[Random.Range(0,4)];
    }


    #endregion

}
