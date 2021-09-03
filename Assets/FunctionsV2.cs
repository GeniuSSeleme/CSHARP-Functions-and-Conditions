using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsV2 : MonoBehaviour
{
    // Start is called before the first frame update
     void Start()
    {
        Sum(5,9);
        Prod(5,9);
        Div(5,9);
    }
    float Sum(float a, float b) 
    {
        Debug.Log(a + b);
        return a + b;
        
       
    }
    float Prod(float a, float b)
    {
        Debug.Log(a * b);
        return a * b;
    }
    float Div(float a, float b)
    {

        if (b <= 0)
        {

            Debug.Log("Error");
            return 0;
        }
        else
        {
            Debug.Log(a/b);
            return a/b;
        }
    }
  

        
        
        

        

  
}
