using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour
{
    public float speed = 6.0f;

    // Update is called once per frame
    void Update()
    {
        // horizontal and vertical are indirect names for keyboard mappings
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        transform.Translate(deltaX, 0, deltaZ);
    }
}
