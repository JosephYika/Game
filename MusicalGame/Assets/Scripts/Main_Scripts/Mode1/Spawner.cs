/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    #region Variables
    public GameObject[] Keys;
    #endregion

    #region Unity Methods
	
    // Start is called before the first frame update
    void Start()
    {
        NewKeys();
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void NewKeys()
    {
        Instantiate(Keys[Random.Range(0, Keys.Length)], transform.position, Quaternion.identity);
    }

    #endregion
}
