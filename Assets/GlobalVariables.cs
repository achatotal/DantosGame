using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public static bool gameOver = false;
    
    public static float speed = -20;

    public static float speedingOverTime = 0;

    public static float score;

    public static int feather;

     void Start()
    {
        // Record the time when the scene starts
        score = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Update the elapsed time
        score += Time.deltaTime;
    }
}
