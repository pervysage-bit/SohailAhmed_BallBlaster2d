using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonMovement : MonoBehaviour
{
    public GameObject bulletPrefab;
    private float horizontalInput;
    private float speed = 10;
    private float xBound = 8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * speed * horizontalInput * Time.deltaTime);

        if (transform.position.x < -xBound)
        {
            transform.position = new Vector2(-xBound, transform.position.y);
        }
        if (transform.position.x > xBound)
        {
            transform.position = new Vector2(xBound, transform.position.y);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, new Vector2(transform.position.x , transform.position.y) , bulletPrefab.transform.rotation);
        }
    }
}
