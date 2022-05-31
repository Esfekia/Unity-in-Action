using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI : MonoBehaviour
{
    // values for the movement speed and distance at which to react to objects
    public float speed = 3.0f;
    public float obstacleRange = 5.0f;
    void Update()
    {
        // move forward continuously every frame, regardless of turning
        transform.Translate(0, 0, speed * Time.deltaTime);

        // a ray at the same position and pointing in the same direction as the character
        Ray ray = new Ray(transform.position, transform.forward);

        RaycastHit hit;

        // perform raycasting with a circular volume around the ray.
        if (Physics.SphereCast(ray, 0.75f, out hit))
        {
            if (hit.distance < obstacleRange)
            {
                // turn toward a semi-random new direction
                float angle = Random.Range(-110, 110);
                transform.Rotate(0, angle, 0);
            }
            
        }
    }
}
