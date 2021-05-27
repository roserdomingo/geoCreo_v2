using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBase : MonoBehaviour
{
    // Start is called before the first frame update

    
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;

    void Start()
    {
        if (Globals.instanceGlobals.cancionSeleccionada == 1) {
            audio1.Play();
        }

        if (Globals.instanceGlobals.cancionSeleccionada == 2) {
            audio2.Play();
        }

        if (Globals.instanceGlobals.cancionSeleccionada == 3) {
            audio3.Play();
        }

        if (Globals.instanceGlobals.cancionSeleccionada == 4) {
            audio4.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
