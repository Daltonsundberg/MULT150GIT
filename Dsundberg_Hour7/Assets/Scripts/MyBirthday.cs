using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
          int birthdayMonth = 2; 

for (int month = 1; month <= 12; month++)
{
    if (month == birthdayMonth)
    {
        print("It's my birthday!"); 
    }
    else
    {
        print(month);
    }
} 
 int birthdayDay = 28; 

for (int day = 1; day <= 28; day++)
{
    if (day == birthdayDay)
    {
        print("It's my birthday!"); 
    }
    else
    {
        print(day);
    }
} 
        }
        


    // Update is called once per frame
    void Update()
    {
        
    }
}
