using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEnemyOnAttack : MonoBehaviour
{
    public float PlusX;
    public float PlusY; 
    public float PlusZ; 

    public GameObject objectToSpawn;

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Angel")){
           
            AudioManager.instance.PlayOneShot(FMODEvents.instance.hostieCollectedSound, this.transform.position);

            // span animation
            Vector3 spawnPosition = new Vector3(transform.position.x + PlusX, transform.position.y + PlusY,transform.position.z + PlusZ);
            GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    
            spawnedObject.transform.Rotate(0, 90, 0);
            
            Destroy(gameObject);
        }
    }

    void Update() {
        if (GlobalVariables.gameOver == true) {
            AudioManager.instance.PlayOneShot(FMODEvents.instance.hostieCollectedSound, this.transform.position);

            // span animation
            Vector3 spawnPosition = new Vector3(transform.position.x + PlusX, transform.position.y + PlusY,transform.position.z + PlusZ);
            GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    
            spawnedObject.transform.Rotate(0, 90, 0);
            
            Destroy(gameObject);
        }
    }

}
