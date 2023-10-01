using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lightbulbv : MonoBehaviour
{
    public Light targetLight;

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.L))
        {
            
            targetLight.enabled = !targetLight.enabled;
        }
    }
}
