using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SonidoPueba : MonoBehaviour
{
    enum TagNamesTypes {Bolas, Suelo, Paredes, Pinchos, TotalTagNames};

    string[] tagNames = { "Bolas", "Suelo", "Paredes", "Pinchos", "TotalTagNames" };

    [SerializeField]
    Object ondas;
    //AudioSource[] audio;



    public AudioSource audio;
    public AudioSource audio2;


    void OnTriggerEnter(Collider target)

    {
       // Audio = GetComponents<AudioSource>();

        var position = new Vector3(transform.position.x, transform.position.y, -2);

        if (target.gameObject.tag.Equals(tagNames[(int)TagNamesTypes.Bolas]))
        {
           audio2.Play();
            
            Instantiate(ondas, position, transform.rotation);
        }

        if (target.gameObject.tag.Equals(tagNames[(int)TagNamesTypes.Suelo]))
        {
           audio.Play();
            
            Instantiate(ondas, position, transform.rotation);

            
        }    
        

    }
}
