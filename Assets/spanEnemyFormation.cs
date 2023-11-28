using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spanEnemyFormation : MonoBehaviour
{
public GameObject objectToSpawn;
    private float circleRadius = 0f;

    public float spawnInterval = 2.5f;
    public float spanAfterSomeTime;

    private bool start = true;

    private void Start()
    {
        
       spawnInterval = spanAfterSomeTime;

        // Start the spawning coroutine
        StartCoroutine(SpawnObjects());
    }

    private IEnumerator SpawnObjects()
    {
        while (!GlobalVariables.gameOver)
        {
            if (!start) {
                Vector2 randomPoint = Random.insideUnitCircle * circleRadius;
                Vector3 spawnPosition = new Vector3(transform.position.x + randomPoint.x, transform.position.y,transform.position.z + randomPoint.y);

                // Instantiate the object at the random position
                GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);

                int randomRotation = (Random.Range(0, 2) * 2 - 1) * 90;

                spawnedObject.transform.Rotate(0, randomRotation, 0);
                spawnedObject.AddComponent<DestroyNotUsedObject>();
                spawnedObject.AddComponent<MoveForward>();

      
            } else {
                
                spawnInterval = spanAfterSomeTime;
                start = false;
            }

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
