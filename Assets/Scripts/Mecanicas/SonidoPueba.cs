using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SonidoPueba : MonoBehaviour
{
    enum TagNamesTypes {Bolas, Suelo, Paredes, Pinchos, TotalTagNames};

    string[] tagNames = { "Bolas", "Suelo", "Paredes", "Pinchos", "TotalTagNames" };

    [SerializeField]
    Object ondas;



    public AudioSource audio;

    void OnTriggerEnter(Collider target)
    {

        var position = new Vector3(transform.position.x, transform.position.y, -2);

        if (target.gameObject.tag.Equals(tagNames[(int)TagNamesTypes.Bolas]))
        {
            audio.Play();
            
            Instantiate(ondas, position, transform.rotation);
        }
        

    }
}
