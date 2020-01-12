using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strawberryPiecesScript : MonoBehaviour
{
    
    public Sprite strawberryPieces;
 
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
