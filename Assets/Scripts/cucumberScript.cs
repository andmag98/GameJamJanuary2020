using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cucumberScript : MonoBehaviour
{
    public SpriteRenderer cucumber; 
    private bool isBeingHeld = false; 
    private float startPosX; 
    private float startPosY; 

    private Vector3 startPos; 

    void Start() {
        startPos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos; 
        mousePos = Input.mousePosition; 
        mousePos = Camera.main.ScreenToWorldPoint(mousePos); 

        if (isBeingHeld == true) {

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, 0); 
        }
        
    }

    private void OnMouseDown() {

        if (Input.GetMouseButtonDown(0)) {

            Vector3 mousePos; 
            mousePos = Input.mousePosition; 
            mousePos = Camera.main.ScreenToWorldPoint(mousePos); 

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            isBeingHeld = true; 
        }

    }

    private void OnMouseUp() {

        isBeingHeld = false; 

        float bolleX = transform.position.x;
        float bolleY = transform.position.y; 

        if (bolleX >= 1.2 && bolleY <= 0) {
             cucumber.enabled = true; 
        }


        gameObject.transform.position = startPos; 

    }
}