using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsMovement : MonoBehaviour
{ 
    public Rigidbody2D ballsRB; 
    private float speed = 1;
   
    // Start is called before the first frame update
    void Start()
    {
        
        ballsRB = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {     
        
        ballsRB.AddForce(Vector2.right * speed * Time.deltaTime , ForceMode2D.Impulse);      
    }






    //void OnCollisionEnter(Collision collision)
    //{
    //    ballsRB.GetComponent<Rigidbody2D>().AddForce(-collision.contacts[0].normal * new Vector2(Random.Range(-5, 5), Random.Range(-5, 5)));
    //}
}