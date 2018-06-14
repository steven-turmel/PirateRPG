using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal sealed class SailControls : MonoBehaviour
{
    private static float turnBonus { get; set; }
    private float anchorDrag { get; set; }
    private bool anchorDropped { get; set; }
    public float movementSpeed;
    private Rigidbody2D rb2d;
    public float torque;
    private const float speedConst = 10f;

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
            if (anchorDropped)
            {
                RaiseAnchor();
            }
            //transform.position += -transform.up * Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
            rb2d.AddRelativeForce(-Vector2.up * movementSpeed * Time.deltaTime * speedConst);
        }
        if (Input.GetKeyDown(KeyCode.Space) && !anchorDropped)
        {
            DropAnchor();
        }
        
    }

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //sr = GetComponent<SpriteRenderer>();
        anchorDrag = 5;
        torque = 0.25f;
        movementSpeed = 100.0f;
    }

    private void DropAnchor()
    {
        anchorDropped = true;
        rb2d.drag += anchorDrag;
    }

    private void RaiseAnchor()
    {
        anchorDropped = false;
        rb2d.drag -= anchorDrag;
    }

    
}
