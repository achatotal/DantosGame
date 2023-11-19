using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
   private Animator animator;

    private void Start()
    {
        // Get the Animator component attached to the GameObject
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Check for some condition to trigger the animation (e.g., a key press)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Set the Trigger parameter to start the animation
            animator.SetTrigger("PlayAnimation");
        }
    }
}
