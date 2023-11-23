using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAction : MonoBehaviour
{
    public Animator animator;
    private int scoreCollision; 
    
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Hostie")){
            scoreCollision += 1;
            Debug.Log(scoreCollision);
        }

        if (other.CompareTag("Enemy") && GlobalVariables.gameOver == false){
            animator.SetTrigger("EnemyCollision");
            GlobalVariables.gameOver = true;
            
        }
    }
}
