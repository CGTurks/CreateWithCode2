using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 30.0f;
    private float topBound = 30;
    private float bottomBound = -10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward *Time.deltaTime *speed);
        if(transform.position.z > topBound) {
            Destroy(gameObject);
        }
        else if(transform.position.z < bottomBound) {
            Destroy(gameObject);
        }
    }
}
