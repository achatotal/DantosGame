using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Animator animator;
    
    public float MovementSpeed;
    public float MovementLimit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GlobalVariables.gameOver == true) {
            return;
        }

        if (Input.GetKey(KeyCode.A)) {
            if (transform.position.z > -MovementLimit){
                transform.position -= new Vector3(0,0,MovementSpeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.D)) {
            if (transform.position.z < MovementLimit){
                     transform.position += new Vector3(0,0,MovementSpeed * Time.deltaTime);
            }
        }
    }


}
