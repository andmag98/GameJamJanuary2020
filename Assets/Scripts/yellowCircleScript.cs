using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowCircleScript : MonoBehaviour
{

    public Sprite yellowCircle;
 
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
