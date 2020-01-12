using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cucumberPiecesScript : MonoBehaviour
{
    
    public Sprite cucumberPieces;
 
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
