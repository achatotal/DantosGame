using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escapeButton : MonoBehaviour
{
    public GameObject disable;
    public GameObject enable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown) {
            disable.SetActive(!disable.activeSelf);
            enable.SetActive(!enable.activeSelf);
        }
    }
}
