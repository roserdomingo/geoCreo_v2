using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ondas : MonoBehaviour
{
    const float ImageWidth = 2000.0f,
                TimeOut = 4.0f;

    enum OndaStates
    {
        Moving,   //The splash image is moving on the screen
        Finish
    }  //Time out, a pressed key or the splash image is just moved, go to main menu scene

    private OndaStates State;
    private float Scale;
    

    float startTime;

   


    // Use this for initialization
    void Start()
    {
        State = OndaStates.Moving;
        startTime = Time.time;

        float Scale = 0.01f;
       

        




    }

    // Update is called once per frame
    void Update()
    {
         float OpacitySpeed = 0.005f; //the speed that your alpha changes
        Color color = GetComponent<SpriteRenderer>().color;
        Scale += 0.07f;
        color.r = 1.0f;
        color.g = 1.0f;
        color.b = 1.0f;
        color.a -= OpacitySpeed;
        


        switch (State)
        {
            case OndaStates.Moving:   //The splash image is moving on the screen
                if (gameObject.transform.name == "Onda1(Clone)")
                {
                    
                    transform.localScale = new Vector3(Scale, Scale, 1);
                    GetComponent<SpriteRenderer>().color = new Color(color.r, color.r, color.r, color.a);

                }

                

                break;
            case OndaStates.Finish:
                if (gameObject.transform.name == "Onda1(Clone)")
                {
                    Debug.Log("destroyed");
                    Destroy(gameObject);
                }
                
                
                break;
            default:
                break;
        }

        if (Time.time - startTime > TimeOut)    //También se puede acabar la presentación por tiempo
            State = OndaStates.Finish;


    }
}
