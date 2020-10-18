using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D body;
    Animator anim;
    SpriteRenderer render;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;
 
    public float runSpeed = 4.0f;

    // Start is called before the first frame update
    void Start ()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        anim.SetFloat("VelocidadeH", Mathf.Abs(horizontal));
        anim.SetFloat("VelocidadeV", vertical);
        if (horizontal < 0)
            render.flipX = true;
        else if (horizontal > 0)
            render.flipX = false;
    }

    void FixedUpdate()
    {
        // Check for diagonal movement
        if (horizontal != 0 && vertical != 0) 
        {
            // limit movement speed diagonally, so you move at 70% speed
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        } 

        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}