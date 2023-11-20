using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngelEnemyCollision : MonoBehaviour
{
    public float PlusX;
    public float PlusY; 
    public float PlusZ; 

    public GameObject objectToSpawn;

    public Animator animator;


    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Pig")){
           
            animator.SetTrigger("EnemyCollision");

            // span animation
            Vector3 spawnPosition = new Vector3(transform.position.x + PlusX, transform.position.y + PlusY,transform.position.z + PlusZ);
            GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    
            spawnedObject.transform.Rotate(0, 90, 0);
            
            GlobalVariables.gameOver = true;
            Destroy(gameObject);
        }
    }
}
