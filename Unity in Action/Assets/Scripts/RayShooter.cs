using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour
{
    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }
        
    void Update()
    {
        // respond to the left mouse button
        if (Input.GetMouseButtonDown(0))
        {
            // use the center of the screen which is half its width and height
            Vector3 point = new Vector3(cam.pixelWidth/2, cam.pixelHeight/2, 0);

            // create the ray at that position by using ScreenPointToRay()
            Ray ray = cam.ScreenPointToRay(point);

            RaycastHit hit;
            
            // fill a referenced variable with information from the raycast
            if (Physics.Raycast(ray, out hit))
            {
                // launch a coroutine in response to a hit
                StartCoroutine(SphereIndicator(hit.point));
            }
        }
    }

    private IEnumerator SphereIndicator(Vector3 pos)
    {
        // create a sphere at pos
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = pos;

        // the yield keyword tells coroutines where to pause
        yield return new WaitForSeconds(1);

        // destroy the sphere after 1 seconds
        Destroy(sphere);
    }
}
