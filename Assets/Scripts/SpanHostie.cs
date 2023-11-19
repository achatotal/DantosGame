using UnityEngine;
using System.Collections;

public class CircleObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float circleRadius = 5.0f;
    public float spawnInterval = 2.0f;
    public float minRotation = 0f;
    public float maxRotation = 360f;

    private void Start()
    {
        // Start the spawning coroutine
        StartCoroutine(SpawnObjects());
    }

    private IEnumerator SpawnObjects()
    {
        while (true)
        {
            Vector2 randomPoint = Random.insideUnitCircle * circleRadius;
            Vector3 spawnPosition = new Vector3(transform.position.x + randomPoint.x, transform.position.y, transform.position.z + randomPoint.y);

             // Generate a random z-rotation
            float randomZRotation = Random.Range(minRotation, maxRotation);

            // Instantiate the object at the random position with the random z-rotation
            GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
            spawnedObject.transform.rotation = Quaternion.Euler(0, randomZRotation, 0);
            spawnedObject.AddComponent<DestroyNotUsedObject>();
            spawnedObject.AddComponent<MoveForward>();

            // Wait for the specified interval (2 seconds) before spawning the next object
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
