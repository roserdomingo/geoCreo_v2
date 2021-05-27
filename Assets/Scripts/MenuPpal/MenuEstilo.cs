using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Prephix MPPal_
//To use this example, attach this script to an empty GameObject. In this case "Menu Manager" object in the hierarchy
//Click the Button in Play Mode to output the message to the console.

enum BotonesMenuEstilo { MEstilo_base1, MEstilo_base2, MEstilo_base3, MEstilo_base4, MEstilo_TotalBotones }

public class MenuEstilo : MonoBehaviour {

    string[] nombreBotonME = {"base1",
                            "base2",
                            "base3",
                            "base4"};

    //Make sure to attach these Buttons in the Inspector
    public Button[] botonME;

    void Start()
    {
        //Create the new space for the buttons
        botonME = new Button[(int)BotonesMenuEstilo.MEstilo_TotalBotones];
        //Select the empty GameObject (Menu Manager) in the Hierarchy 
        //Drag and drop each one of the UI Buttons from the Hierarchy to the every Button array fields in the Inspector when the Menu Manager empty gameObject is selected

        for (int i = (int)BotonesMenuEstilo.MEstilo_base1; i< (int)BotonesMenuEstilo.MEstilo_TotalBotones;i++)
            botonME[i] = GameObject.Find(nombreBotonME[i]).GetComponent<Button>();

        //Calls the jugarClicked method when you click the Button Jugar
        botonME[(int)BotonesMenuEstilo.MEstilo_base1].onClick.AddListener(base1Clicked);

        botonME[(int)BotonesMenuEstilo.MEstilo_base2].onClick.AddListener(base2Clicked);

        botonME[(int)BotonesMenuEstilo.MEstilo_base3].onClick.AddListener(base3Clicked);

        botonME[(int)BotonesMenuEstilo.MEstilo_base4].onClick.AddListener(base4Clicked);

    }

    // Update is called once per frame
    void Update()
    {
    }

    void base1Clicked()
    {
        //Output this to console when the Button is clicked
        Globals.instanceGlobals.cancionSeleccionada = 1;
    }


    void base2Clicked()
    {
        //Output this to console when the Button is clicked
        Globals.instanceGlobals.cancionSeleccionada = 2;
    }



    void base3Clicked()
    {
        //Output this to console when the Button is clicked
        Globals.instanceGlobals.cancionSeleccionada = 3;
    }



    void base4Clicked()
    {
        //Output this to console when the Button is clicked
        Globals.instanceGlobals.cancionSeleccionada = 4;
        Debug.Log("hola");
    } 
}



 
