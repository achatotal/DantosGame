using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fogEffect : MonoBehaviour
{
  // Reference to the camera
    public Camera mainCamera;

    // The maximum distance at which the sprite is fully opaque
    public float maxDistance = 100f;

    // The minimum distance at which the sprite is fully transparent
    public float minDistance = 2f;

    // Reference to the sprite renderer
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Get the sprite renderer component
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Check if the camera reference is null, and if so, use the main camera
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
    }

    void Update()
    {
        // Calculate the distance from the sprite to the camera
        float distanceToCamera = Vector3.Distance(transform.position, mainCamera.transform.position);

        // Calculate the opacity based on the distance
        float opacity = Mathf.Clamp01((maxDistance - distanceToCamera) / (maxDistance - minDistance));

        // Apply the opacity to the sprite renderer
        Color spriteColor = spriteRenderer.color;
        spriteColor.a = opacity;
        spriteRenderer.color = spriteColor;
    }
}
