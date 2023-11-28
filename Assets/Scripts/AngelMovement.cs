using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class AngelMovement : MonoBehaviour
{
    [SerializeField] private EventReference angelCrashSound;
    public Animator animator;

    public static float MovementSpeed = 2f;
    public static float MovementLimit = 1.1f;


    // Attack variables

    private Vector3 startPosition;
    private Vector3 endPosition;

    public float lerpSpeed = 1.0f;
    public float lerpDistance = 10.0f;

    public static bool isLerping = false;
    private bool isLerpingForward = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow) && isLerping == false && GlobalVariables.gameOver == false) {
            if (transform.position.z > -MovementLimit){
                transform.position -= new Vector3(0,0,MovementSpeed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow) && isLerping == false && GlobalVariables.gameOver == false) {
            if (transform.position.z < MovementLimit){
                     transform.position += new Vector3(0,0,MovementSpeed * Time.deltaTime);
            }
        }

        // Attack
        if (Input.GetKey(KeyCode.K) && isLerping == false && GlobalVariables.gameOver == false && GlobalVariables.feather >= 1) {
            startPosition = transform.position;

            //Set the initial end position as 10 units down from the start position
            endPosition = startPosition - new Vector3(0.0f, lerpDistance, 0.0f);

            animator.SetTrigger("Attack");
            AudioManager.instance.PlayOneShot(angelCrashSound, this.transform.position);

            isLerping = !isLerping; // Toggle the lerp on the 'K' key press
            isLerpingForward = true; // Reset the lerp direction to forward

            GlobalVariables.feather -= 1;
        }

        if (isLerping)
        {
            // Lerp between the start and end positions
            if (isLerpingForward)
            {
                transform.position = Vector3.Lerp(transform.position, endPosition, lerpSpeed * Time.deltaTime);

                // Check if the object has reached the end position
                if (Vector3.Distance(transform.position, endPosition) < 0.001f)
                {
                    isLerpingForward = false; // Switch to backward lerp
                }
            }
            else
            {
                transform.position = Vector3.Lerp(transform.position, startPosition, lerpSpeed * Time.deltaTime);

                // Check if the object has reached the start position
                if (Vector3.Distance(transform.position, startPosition) < 0.001f)
                {
                    isLerping = false; // Lerp is complete, stop lerping
                }
            }
        }

    }
}
