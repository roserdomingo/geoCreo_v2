using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImgFondo : MonoBehaviour {

    const float ImageWidth = 2000.0f,
                TimeOut    =    4.0f;

    public enum SplashStates {Moving,   //The splash image is moving on the screen
                              Finish }  //Time out, a pressed key or the splash image is just moved, go to main menu scene

    public SplashStates State;
    public Vector2      Speed;  //Speed for moving the image on the screen

    float startTime;

    Image image;
    

    // Use this for initialization
    void Start () {
        State = SplashStates.Moving;
        startTime = Time.time;
        image = GetComponent<Image>();
       
    }

    // Update is called once per frame
    void Update () {
        switch (State)
        {
            case SplashStates.Moving:   //The splash image is moving on the screen
                transform.Translate (Speed.x * Time.deltaTime, Speed.y * Time.deltaTime, 0.0f);
         
                break;
            case SplashStates.Finish:
                SceneManager.LoadScene("MenuPpal");
                break;
            default:
                break;
        }

        if (Time.time - startTime > TimeOut)    //También se puede acabar la presentación por tiempo
            State = SplashStates.Finish;

        if (Input.GetKey(KeyCode.Escape) || //Si se pulsa la tecla escape
            Input.GetKey(KeyCode.Return) || //Si se pulsa la tecla enter
            Input.GetKey(KeyCode.Space))    //Si se pulsa la tecla espacio

            State = SplashStates.Finish;
    }
}
