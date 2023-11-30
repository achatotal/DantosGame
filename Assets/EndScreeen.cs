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
    {   
        ScoreInt = Mathf.Round(GlobalVariables.score);
        if(GlobalVariables.gameOver && !callOnes)
        {
            endScreneObj.SetActive(true);
            pointsText.text = ScoreInt + "m";
            callOnes = true;
        }

        if (GlobalVariables.gameOver == false) {
            return;
        }

if (Input.GetKeyDown("k") || Input.GetKeyDown("e") || Input.GetKeyDown("f") || Input.GetKeyDown("g") || Input.GetKeyDown("r") || Input.GetKeyDown("l")) {
          int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Reload the current scene
        SceneManager.LoadScene(currentSceneIndex);
        GlobalVariables.gameOver = false;
        GlobalVariables.feather = 0;
        GlobalVariables.score = 0;
        GlobalVariables.speed = -20;

                    SceneManager.LoadScene("Menu_UI");
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
