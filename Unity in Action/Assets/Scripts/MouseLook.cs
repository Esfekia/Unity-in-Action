using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // define an enum data structure to associate names with settings
    public enum RotationAxes
    {
        MouseXandY = 0,
        MouseX = 1,
        MouseY = 2
    }
    
    // declare a public variable to set in Unity's editor
    public RotationAxes axes = RotationAxes.MouseXandY;

    // Update is called once per frame
    void Update()
    {
        if (axes == RotationAxes.MouseX)
        {
            // horizontal rotation here
        }

        else if (axes == RotationAxes.MouseY)
        {
            // vertical rotation here
        }

        else
        {
            // both horizontal and vertical rotation here
        }
    }
}
