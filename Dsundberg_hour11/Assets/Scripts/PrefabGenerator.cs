using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject lampPrefab;
    public float lampSpacing = 2.0f; 

    void Start()
    {
        Vector3 spawnPosition = transform.position; 
        for (int i = 0; i < 10; i++)
        {
            
            GameObject lamp = Instantiate(lampPrefab, spawnPosition, Quaternion.identity);

            
            lamp.transform.parent = transform;

         
            spawnPosition.x += lampSpacing;
        }
    }


    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(lampPrefab);
        }

       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(lampPrefab, transform.position, transform.rotation);
        }
    }
}