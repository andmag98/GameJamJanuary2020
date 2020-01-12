using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brownCircleScript : MonoBehaviour
{
    
    public Sprite brownCircle;
 
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
