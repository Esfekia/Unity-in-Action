using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour
{
    public float speed = 6.0f;

    // variable for referencing the CharacterController
    private CharacterController charController;

    private void Start()
    {
        // access the CharacterController attached to this object
        charController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // horizontal and vertical are indirect names for keyboard mappings
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);

        // limit diagonal movement to the same speed as movement along an axis
        movement = Vector3.ClampMagnitude(movement, speed);
        
        // tell the CharacterController to move by that vector
        charController.Move(movement);
        //transform.Translate(deltaX * Time.deltaTime, 0, deltaZ * Time.deltaTime);       
                
    }
}
