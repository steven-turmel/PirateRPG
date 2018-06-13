using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class SailControls : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float torque = 0.15f;
    public float speed;
    SpriteRenderer sr;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(torque, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(-torque, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb2d.AddRelativeForce(-transform.up, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb2d.AddRelativeForce(transform.up, ForceMode2D.Force);
        }
        if (rb2d.angularVelocity > 0.10)
        {
            sr.sprite = 
        }
    }

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    
}
