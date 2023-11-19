using UnityEngine;

public class MoveDownUp : MonoBehaviour
{
    public float downDistance = 1.0f;  // Set the distance to move down
    public float upDistance = 1.0f;    // Set the distance to move up
    public float speed = 1.0f;         // Set the speed of the movement
    
    private bool isMoving = false;
    private bool movingDown = true;

    private void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            isMoving = !isMoving; // Toggle the movement on the 'K' key press
            Debug.Log("keypresss");
        }

        if (isMoving)
        {
            // Calculate the vertical movement
            float verticalMovement = 0.0f;

            if (movingDown)
            {
                // Move down
                verticalMovement = -speed * Time.deltaTime;
                transform.Translate(0.0f, verticalMovement, 0.0f);

                // Check if the object has moved down the specified distance
                if (transform.position.y <= -downDistance)
                {
                    movingDown = false;
                }
            }
            else
            {
                // Move up
                verticalMovement = speed * Time.deltaTime;
                transform.Translate(0.0f, verticalMovement, 0.0f);

                // Check if the object has moved up the specified distance
                if (transform.position.y >= upDistance)
                {
                    movingDown = true;
                }
            }
        }
    }
}
