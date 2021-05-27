using UnityEngine;
using UnityEngine.UI;
public class Globals : MonoBehaviour {
    
    public static Globals instanceGlobals;
 
    public int cancionSeleccionada = 1;
    private void Awake()
    {
        if (instanceGlobals == null)
        {
            instanceGlobals = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }
    private void Update()
    {
     
    }
}