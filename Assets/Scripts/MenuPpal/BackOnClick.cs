using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class BackOnClick : MonoBehaviour {



    public Button ButtonBack;
    bool buttonPressed = false;

    // Use this for initialization
    void Start () {

        //ButtonBack.SetActive(true);

        ButtonBack = GameObject.Find("ButtonBack").GetComponent<Button>();
               
    }
	
	// Update is called once per frame
	void Update () {
        //ButtonBack.SetActive(false);

        if (buttonPressed == false)
        {
            ButtonBack.onClick.AddListener(goBack);

            if (Input.GetKey(KeyCode.Escape))
                goBack();
        }

        buttonPressed = true;
        
    }


    void goBack()
    {
        //Output this to console when the Button is clicked
        Debug.Log("You have clicked the button Back!");
        SceneManager.LoadScene(1);
        
    }

}
