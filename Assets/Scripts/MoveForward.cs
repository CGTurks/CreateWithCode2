using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 30.0f;

    private float topBound = 30;
    private float bottomBound = -10;
    private float leftBound = -30;  // New left boundary
    private float rightBound = 30;  // New right boundary

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Destroy object if it goes out of any bounds
        if (transform.position.z > topBound || transform.position.z < bottomBound ||
            transform.position.x < leftBound || transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
    }
}

