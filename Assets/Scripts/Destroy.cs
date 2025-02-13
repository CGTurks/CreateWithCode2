using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound = 30.0f;
    private float lowerBound = -10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound) {
            Destroy(gameObject);
            }
        else if(transform.position.z < lowerBound) {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        } 
        
        
    }
    

