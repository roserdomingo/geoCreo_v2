using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CambioColor : MonoBehaviour
{


    private void Start() {
        GetComponent<Renderer>().material.color = new Color(0.2f,0.2f,0.2f);  
    }


    private void OnCollisionEnter (Collision target)
    {
        if(target.gameObject.name.Contains("blue") == true ) 
        {
            GetComponent<Renderer>().material.color = new Color(0.4f,0.6f,1.0f);   
        }

        if(target.gameObject.name.Contains("orange") == true ) 
        {
            GetComponent<Renderer>().material.color = new Color(1.0f,0.5f,0f);   
        }

        if(target.gameObject.name.Contains("red") == true ) 
        {
            GetComponent<Renderer>().material.color = new Color(1.0f,0.2f,0.2f);   
        }

        if(target.gameObject.name.Contains("yellow") == true ) 
        {
            GetComponent<Renderer>().material.color = new Color(1.0f,1.0f,0f);   
        }

        if(target.gameObject.name.Contains("green") == true ) 
        {
            GetComponent<Renderer>().material.color = new Color(0.4f,1.0f,0.4f);   
        }
    }
    
}
