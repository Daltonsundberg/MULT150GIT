using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour
{
    
    public float moveSpeed = 500.0f; 

    void Update()
    {
       
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        
        Vector3 moveDirection = new Vector3(mouseX, mouseY, 0);

        
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}

