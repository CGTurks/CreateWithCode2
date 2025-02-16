using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 30.0f;

    private float topBound = 30;
    private float bottomBound = -10;
    private float leftBound = -30;  
    private float rightBound = 30;  
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        
        if (transform.position.z > topBound || transform.position.z < bottomBound ||
            transform.position.x < leftBound || transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
    }
}

