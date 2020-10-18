using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MonsterMovement : MonoBehaviour
{
    Animator anim;
    SpriteRenderer render;

    public Transform player;
    private Rigidbody2D rb;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;

    public float runSpeed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        render = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector3 dir = player.position - transform.position;
        horizontal = dir.x;
        vertical = dir.y;

        anim.SetFloat("VelocidadeH", Mathf.Abs(horizontal));
        anim.SetFloat("VelocidadeV", vertical);
        if (horizontal < 0)
            render.flipX = true;
        else if (horizontal > 0)
            render.flipX = false;
    }

    void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0) // Check for diagonal movement
        {
            // limit movement speed diagonally, so you move at 70% speed
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        rb.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}
