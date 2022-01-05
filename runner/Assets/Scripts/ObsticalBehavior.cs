using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticalBehavior : MonoBehaviour
{
    float speed = 10;

    public GameObject wall;

    private void Update()
    {
        // handles the moving
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        // handles deleting offscreen assets
        if (transform.position.x <= -3)
        {
            Destroy(wall);
        }
    }

}
