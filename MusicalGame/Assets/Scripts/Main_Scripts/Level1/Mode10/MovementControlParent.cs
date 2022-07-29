/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControlParent : MonoBehaviour
{
    #region Variables


    private Vector2 targetPos;
    public float XIncrement;

    
    public float speed;
    

    public float maximumX_Positive;
    public float minimumX_Negative;

    private float previousTime;
    public float fallTime = 0.8f;

    public float respawnTime = 4.0f;

    private GameObject _note;
    private KeyboardLerpMovement move;

    

    
    #endregion

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        
        move = FindObjectOfType<KeyboardLerpMovement>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //  transform.position = Vector2.MoveTowards(transform.position, targetPos, velocity * Time.deltaTime);
        
       
            
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        
            
      
       

        



        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maximumX_Positive)
        {
            targetPos = new Vector2(transform.position.x + XIncrement, transform.position.y);
            transform.position = targetPos;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minimumX_Negative)
        {
            targetPos = new Vector2(transform.position.x - XIncrement, transform.position.y);
            transform.position = targetPos;
        }



        

    }

    void OnTriggerEnter2D(Collider2D pianoKey)
    {

        if(pianoKey.CompareTagsExtension()) 
        {

            _note = GameObject.FindObjectOfType<SpawnerParent>().Note;
            if(_note != null)
            {

                Destroy(_note);

            }
            
            move.MovetoNextPosition();
            Debug.Log("Move Position triggered");
            
            
        }
        

  
    }

    


    #endregion
}

// Extension for checking whether the note hit the specific key 
