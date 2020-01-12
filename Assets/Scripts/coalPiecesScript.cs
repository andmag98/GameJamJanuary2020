using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coalPiecesScript : MonoBehaviour
{
    
    public Sprite coalPieces;
 
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
