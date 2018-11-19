using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChanger : MonoBehaviour {

    private Rigidbody2D rb;
    private bool top;
    private bool canJump = true;

    private Vector2 startPosition;
    private bool moveLeft = false;

    private float speed = 0.05f;

    // Use this for initialization
    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0) && canJump == true)
        {
            rb.gravityScale *= -1;
            Rotation();
        }
        if (moveLeft == true)
        {
            transform.position = new Vector2(transform.position.x - speed, transform.position.y);
        }
        
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Hitbox")
        {
            canJump = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Hitbox")
        {
            canJump = false;
        }
        if (other.tag == "HitboxLeft")
        {
            moveLeft = false;
        }

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "HitboxLeft")
        {
            moveLeft = true;
        }
    }

    void Rotation()
    {
        if (top == false)
        {
            transform.eulerAngles = new Vector3(0, 180f, 180f);
        }
        else
        {
            transform.eulerAngles = Vector3.zero;
        }

        top = !top;
    }


}
