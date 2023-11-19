using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAction : MonoBehaviour
{
    public Animator animator;

    private int score; 

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Hostie")){
            score += 1;
        }

        if (other.CompareTag("Enemy") && GlobalVariables.gameOver == false){
            animator.SetTrigger("EnemyCollision");
            GlobalVariables.gameOver = true;
        }
    }
}
