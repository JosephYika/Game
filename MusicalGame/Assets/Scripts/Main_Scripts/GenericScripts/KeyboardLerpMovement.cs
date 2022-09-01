/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardLerpMovement : MonoBehaviour
{
    #region Variables

    public Vector3 endPosition;
    public List<Vector3> endPositions;
    private Vector3 startPosition;
    private float desiredDuration = 4f;
    private float elapsedTime;
    #endregion

    #region Unity Methods
	
    // Start is called before the first frame update
    void Start()
    {
        endPositions = new List<Vector3>();
        endPositions.Add(new Vector3(-16.5f, -0.1688532f, 0));      
        endPositions.Add(new Vector3(-12.5f, -0.1688532f, 0));       
        endPositions.Add(new Vector3(-8.5f, -0.1688532f, 0));
        endPositions.Add(new Vector3(-4.5f, -0.1688532f, 0));        
        endPositions.Add(new Vector3(-2.5f, -0.1688532f, 0));     
        endPositions.Add(new Vector3(1.5f, -0.1688532f, 0));


    }

    // Update is called once per frame
    void Update()
    {

       
    }

    public void MovetoNextPosition()
    {
       
        Debug.Log(transform.position.x + ": Position X ");
        startPosition = transform.position;
        elapsedTime = elapsedTime + Time.deltaTime;
        float percentageComplete = elapsedTime / desiredDuration;
        endPosition = endPositions[Random.Range(0, 5)];

        while (transform.position.x < endPosition.x - 0.01 || transform.position.x > endPosition.x + 0.01) 
        {
            startPosition = transform.position;            
            transform.position = Vector3.Lerp(startPosition,endPosition, percentageComplete);
        }
        
    }

    #endregion
}
