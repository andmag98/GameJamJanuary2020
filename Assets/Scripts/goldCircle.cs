using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldCircle : MonoBehaviour
{
    
    public Sprite gold;
 
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
