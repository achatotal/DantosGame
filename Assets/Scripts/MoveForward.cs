using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GlobalVariables.speed -= Time.time/GlobalVariables.speedingOverTime;
        transform.position -= new Vector3(GlobalVariables.speed * Time.deltaTime,0,0);

        if (GlobalVariables.gameOver == true) {
            GlobalVariables.speed = 0;
        }
    }
}
