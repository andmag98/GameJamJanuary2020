using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolle : MonoBehaviour
{
    

    public Sprite bolleSprite;
 
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
