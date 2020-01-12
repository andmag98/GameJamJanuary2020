using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maskeScript : MonoBehaviour
{
    public SpriteRenderer mask; 
    
    private Vector3 mousePos; 

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition; 

        if ( mousePos.x >= 1000 &&  mousePos.y <= 400) {

            if (Input.GetKeyDown(KeyCode.Mouse0)) {
               mask.enabled = true; 
             
            }
        }
    }



}
