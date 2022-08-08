using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tesat : MonoBehaviour {    
    public float DropSpeed;
    Rigidbody2D rb;
    Vector2 lastVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Apply your initial velocity on spawn.
        // Then you don't need to transform the object every update tick.
    }
    
    // Do this in FixedUpdate, so you're caching the velocity in every
    // physics step, rather than only on rendered frames.
    void FixedUpdate()
    {
        lastVelocity = rb.velocity;
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall" || collision.gameObject.tag == "MammalianCell" || collision.gameObject.tag == "InfectedMammalianCell" || collision.gameObject.tag == "UnaffectedMammalianCell") {
            var speed = lastVelocity.magnitude;
            var direction = Vector2.Reflect(lastVelocity.normalized, collision.contacts[0].normal); // .contact.normal draws a line at the normal of the collision
    
            rb.velocity = direction * Mathf.Max(speed, 1f);
        }
    }
}