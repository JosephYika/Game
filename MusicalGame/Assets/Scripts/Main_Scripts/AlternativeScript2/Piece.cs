/*
 Copyright (c) Józef Yika
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    #region Variables
    public Platform platform { get; private set; }
    public TetrominoData data { get; private set; }
    public Vector3Int position { get; private set; }
    public Vector3Int[] cells { get; private set; }
    #endregion

    #region Unity Methods

    public void Initialize(Platform platform,Vector3Int position, TetrominoData data)
    {
        this.platform = platform;
        this.position = position;
        this.data = data;

        if(this.cells == null)
        {
            this.cells = new Vector3Int[data.cells.Length];
        }
        for (int i = 0; i < data.cells.Length; i++)
        {
            this.cells[i] = (Vector3Int)data.cells[i];
        }
    }

    #endregion
}
