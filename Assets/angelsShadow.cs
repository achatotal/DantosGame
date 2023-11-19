using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class angelsShadow : MonoBehaviour
{
    private float MovementSpeedShadow = AngelMovement.MovementSpeed;
    private float MovementLimitShadow = AngelMovement.MovementLimit;

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

        if (Input.GetKey(KeyCode.LeftArrow) && AngelMovement.isLerping == false) {
            if (transform.position.z > -MovementLimitShadow){
                transform.position -= new Vector3(0,0,MovementSpeedShadow * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow) && AngelMovement.isLerping == false) {
            if (transform.position.z < MovementLimitShadow){
                     transform.position += new Vector3(0,0,MovementSpeedShadow * Time.deltaTime);
            }
        }
    }
}
