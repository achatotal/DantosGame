using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class EndScreeen : MonoBehaviour
{
    public GameObject endScreneObj;
    public TextMeshProUGUI pointsText;
    public CollisionAction collisionAction;
    private float ScoreInt;
    private bool callOnes = false;

    void Start(){
        endScreneObj.SetActive(false);
    }
    
    public void Update()
    {   ScoreInt = GlobalVariables.score;
        if(GlobalVariables.gameOver && !callOnes)
        {
            endScreneObj.SetActive(true);
            pointsText.text = ScoreInt + "m";
            callOnes = true;
        }
    }
    public void RestartButton() 
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ExitButton() 
    {

    }
}
