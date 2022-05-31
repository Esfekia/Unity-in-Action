using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI : MonoBehaviour
{
    // values for the movement speed and distance at which to react to objects
    public float speed = 3.0f;
    public float obstacleRange = 5.0f;

    // check if the enemy is alive
    private bool isAlive;

    private void Start()
    {
        isAlive = true;
    }
    public void SetAlive(bool alive)
    {
        isAlive = alive;
    }
    void Update()
    {
        // move only if the enemy is alive
        if (isAlive)
            // move forward continuously every frame, regardless of turning
            transform.Translate(0, 0, speed * Time.deltaTime);

        // a ray at the same position and pointing in the same direction as the enemy
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
