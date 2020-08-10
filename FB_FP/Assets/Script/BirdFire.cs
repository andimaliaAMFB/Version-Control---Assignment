using System.Collections;
using System.Collections.Generic ;
using UnityEngine;

public class BirdFire : MonoBehaviour
{
    //Global variables
    public float speed = 10f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * speed*Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Pipe pipe = hitInfo.GetComponent<Pipe>();
        Destroy(gameObject);
    }
}