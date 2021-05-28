using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


enum UIbuttons { button_0, button_1, button_2, button_3, button_4, totalBotones }

public class SpawnerScript04 : MonoBehaviour
{

    string[] buttonName = {"Button0",
                            "Button1",
                            "Button2",
                            "Button3",
                            "Button4" };

    public GameObject[] spheres;
    public Button[] gameButton;
    // Start is called before the first frame update
    void Start()
    {
        //Create the new space for the buttons
        gameButton = new Button[(int)UIbuttons.totalBotones];


        for (int i = (int)UIbuttons.button_0; i < (int)UIbuttons.totalBotones; i++)
            gameButton[i] = GameObject.Find(buttonName[i]).GetComponent<Button>();

        //Calls the jugarClicked method when you click the Button Jugar
        gameButton[(int)UIbuttons.button_0].onClick.AddListener(B0clicked);
        gameButton[(int)UIbuttons.button_1].onClick.AddListener(B1clicked);
        gameButton[(int)UIbuttons.button_2].onClick.AddListener(B2clicked);
        gameButton[(int)UIbuttons.button_3].onClick.AddListener(B3clicked);
        gameButton[(int)UIbuttons.button_4].onClick.AddListener(B4clicked);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)) SpawnObjects(0);
       
    }

    public void B0clicked()
    {
        SpawnObjects(0);
    }
    public void B1clicked()
    {
        SpawnObjects(1);
    }
    public void B2clicked()
    {
        SpawnObjects(2);
    }
    public void B3clicked()
    {
        SpawnObjects(3);
    }
    public void B4clicked()
    {
        SpawnObjects(4);
    }


    public void SpawnObjects(int num)
    {

        var position = new Vector3(Random.Range(-2.0f, 2.0f), 11, -2);
        Instantiate(spheres[num], position, transform.rotation);
    }

 

    

}




