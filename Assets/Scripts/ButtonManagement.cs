using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonManagement : MonoBehaviour
{
    public GameObject [] btn;

    float horizontal;
    float vertical;

    int selected_Button = 0;

    bool buttonpressed = false;
    // Start is called before the first frame update
    void Start()
    {
        btn = GameObject.FindGameObjectsWithTag("Button");

    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown("left") || Input.GetKeyDown("a"))
        {
            if (selected_Button == 2) {
              selected_Button = 0;
            } else {
                selected_Button = 1;
            }

        } 

        if (Input.GetKeyDown("right") || Input.GetKeyDown("d"))
        {
            if (selected_Button == 1) {
              selected_Button = 0;
            } else {
                selected_Button = 2;
            }

        }

        if (Input.GetKeyDown("k") || Input.GetKeyDown("e") || Input.GetKeyDown("f") || Input.GetKeyDown("g") || Input.GetKeyDown("r") || Input.GetKeyDown("l")) {
            btn[selected_Button].GetComponent<Button>().onClick.Invoke(); 
        }

        if (btn.Length > 0) {

            for (int a = 0; a<btn.Length; a++) {
                if(a == selected_Button) {
                    btn[a].GetComponent<Button>().Select();
                } else {
                    btn[a].GetComponent<Image>().color = Color.white;
                }
            }

        } else {
            //selected_Button = 0;
        }
    }


}
