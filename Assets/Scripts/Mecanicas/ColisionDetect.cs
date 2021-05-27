using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum sphereCollisions { sphere_0, sphere_1, sphere_2, sphere_3, sphere_4, totalSpheres }

public class ColisionDetect : MonoBehaviour
{
    string[] sphereName = {"blue",
                            "orange",
                            "red",
                            "yellow",
                            "green" };

    public GameObject[] collisionSphere;
    public AudioSource[] sonido;

    private void Start()
    {

        collisionSphere = new GameObject[(int)sphereCollisions.totalSpheres];


        for (int i = (int)sphereCollisions.sphere_0; i < (int)sphereCollisions.totalSpheres; i++)
        {
            collisionSphere[i] = GameObject.Find(sphereName[i]).GetComponent<GameObject>();
            sonido[i] = GameObject.Find(sphereName[i]).GetComponent<AudioSource>();
        }
       print(sonido);
    }
    

    private void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.name.Equals("base") == true)
        {
            Color randomlySelectedColor = GetRandomColor();
            GetComponent<Renderer>().material.color = randomlySelectedColor;
            //sonido1.Play();
        }
    }

    // Update is called once per frame
    private Color GetRandomColor()
    {
        return new Color(
            r: UnityEngine.Random.Range(0f, 1f),
            g: UnityEngine.Random.Range(0f, 1f),
            b: UnityEngine.Random.Range(0f, 1f));
    }
}
