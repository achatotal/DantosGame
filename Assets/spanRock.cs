using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spanRock : MonoBehaviour
{
    private string lastRockName;

    private SpriteRenderer spriteRenderer;

    public GameObject[] gameObjects;
    public List<Color> availableColors = new List<Color>();

    public float circleRadius = 5.0f;
    public float spawnInterval = 2.0f;

    private void Start()
    {
        spawnInterval = Random.Range(1f, 2.0f);
        spawnInterval = Mathf.Round(spawnInterval * 10.0f) * 0.1f;

        // Start the spawning coroutine
        StartCoroutine(SpawnObjects());
    }

    private IEnumerator SpawnObjects()
    {
        while (!GlobalVariables.gameOver)
        {
            Vector2 randomPoint = Random.insideUnitCircle * circleRadius;
            Vector3 spawnPosition = new Vector3(transform.position.x + randomPoint.x, transform.position.y,transform.position.z + randomPoint.y);

            // Instantiate the object at the random position
            GameObject objectToSpawn = gameObjects[Random.Range(0, gameObjects.Length)];
            
            // Choose different rock than last time
            while(lastRockName == objectToSpawn.name) {
                objectToSpawn = gameObjects[Random.Range(0, gameObjects.Length)];
            }

            lastRockName = objectToSpawn.name;
          
            // choose random color and change color of sprite 
            Color randomColor = availableColors[Random.Range(0, availableColors.Count)];
            Color randomColorWithAlpha = AddAlpha(randomColor, 0f);
            spriteRenderer = objectToSpawn.GetComponent<SpriteRenderer>();
            spriteRenderer.color = randomColorWithAlpha;

            GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
            spawnedObject.AddComponent<DestroyNotUsedObject>();
            spawnedObject.AddComponent<MoveForward>();

            int randomRotation = (Random.Range(0, 2) * 2 - 1) * 90;

            spawnedObject.transform.Rotate(0, randomRotation, 0);

            spawnInterval = Random.Range(1f, 2.0f);
            spawnInterval = Mathf.Round(spawnInterval * 10.0f) * 0.1f;

            // Wait for the specified interval (2 seconds) before spawning the next object
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    Color AddAlpha(Color color, float alpha)
    {
        return new Color(color.r, color.g, color.b, alpha);
    }
}
