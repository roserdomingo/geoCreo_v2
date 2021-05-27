using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Prephix MPPal_
//To use this example, attach this script to an empty GameObject. In this case "Menu Manager" object in the hierarchy
//Click the Button in Play Mode to output the message to the console.

enum BotonesMenuPpal { MPPal_Jugar, MPPal_ModoDeJuego, MPPal_Ajustes, MPPal_Salir, MPPal_TotalBotones }

public class MenuPpal : MonoBehaviour {

    string[] nombreBoton = {"Jugar",
                            "ModoDeJuego",
                            "Ajustes",
                            "Salir"};

    //Make sure to attach these Buttons in the Inspector
    public Button[] boton;

    void Start()
    {
        //Create the new space for the buttons
        boton = new Button[(int)BotonesMenuPpal.MPPal_TotalBotones];
        //Select the empty GameObject (Menu Manager) in the Hierarchy 
        //Drag and drop each one of the UI Buttons from the Hierarchy to the every Button array fields in the Inspector when the Menu Manager empty gameObject is selected

        for (int i = (int)BotonesMenuPpal.MPPal_Jugar; i< (int)BotonesMenuPpal.MPPal_TotalBotones;i++)
            boton[i] = GameObject.Find(nombreBoton[i]).GetComponent<Button>();

        //Calls the jugarClicked method when you click the Button Jugar
        boton[(int)BotonesMenuPpal.MPPal_Jugar].onClick.AddListener(jugarClicked);

        boton[(int)BotonesMenuPpal.MPPal_ModoDeJuego].onClick.AddListener(delegate { genericClicked("Pressed button Puntuaciones"); });
        boton[(int)BotonesMenuPpal.MPPal_ModoDeJuego].onClick.AddListener(GameModeEnter);

        boton[(int)BotonesMenuPpal.MPPal_Ajustes].onClick.AddListener(delegate { genericClicked("Pressed button Opciones"); });
        boton[(int)BotonesMenuPpal.MPPal_Ajustes].onClick.AddListener(AjustesEnter);

        boton[(int)BotonesMenuPpal.MPPal_Salir].onClick.AddListener(salirClicked);
    }

    // Update is called once per frame
    void Update()
    {
        //Regla del escape
        if (Input.GetKey(KeyCode.Escape))
            salirClicked();

        //Regla del enter
        if (Input.GetKey(KeyCode.Return))
            jugarClicked();
    }

    void jugarClicked()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button Jugar!");
        SceneManager.LoadScene(2);
    }

    void GameModeEnter()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button Modo de Juego!");
        SceneManager.LoadScene(3);
    }

    void AjustesEnter()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button Ajustes!");
        SceneManager.LoadScene(4);
    }



    void salirClicked()
    {
        //Se cierra la aplicación
       // Application.Quit();
        //Se cierra la ejecución si se está en el entorno de desarrollo Unity 3D
      //  UnityEditor.EditorApplication.isPlaying = false;

      if (Input.GetKeyUp(KeyCode.Escape))
         {
             if (Application.platform == RuntimePlatform.Android)
             {
                 AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
                 activity.Call<bool>("moveTaskToBack", true);
             }
             else
             {
                 Application.Quit();
             }
         }
    }

   

    void genericClicked(string message)
    {
        //Output this to console when the Button is clicked
        Debug.Log(message);
    }
}
