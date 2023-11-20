using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnGameOver : MonoBehaviour
{
    public static float timeFromStart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalVariables.gameOver) {
            Destroy(gameObject);
        }

        timeFromStart = Time.time;
    
    }
}
