using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{

    private float yBound = 6;
    private float xBound = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > yBound)
        {
            Destroy(gameObject);
        } 
        
        else if(transform.position.x > xBound)
        {
            Destroy(gameObject);
        }
    }
}
