using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAfterSomeTime : MonoBehaviour
{
  public float destroyDelay = 2.0f; // Set the time delay in seconds

    private void Start()
    {


        // Call the DestroyObject function after the specified delay7
        if(Mathf.RoundToInt((float)transform.position.z) != Mathf.RoundToInt((float)-14.5741)) {
            Invoke("DestroyObject", destroyDelay);
        }

    }

    private void DestroyObject()
    {
        Destroy(gameObject);
    }

}
