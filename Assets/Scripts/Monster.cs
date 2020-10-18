using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monster : MonoBehaviour
{
    public GameObject monster;
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    public float moveSpeed=1f;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = player.position - transform.position;
        //float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        //rb.rotation = angle; //(rotate enemy to face player)!!
        //dir.Normalize();
        movement = dir;

    }
    private void FixedUpdate()
    {
        MoveEnemy(movement);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Projectile")
        {
            Destroy(monster);
            Invoke("WinCondition", 3);
        }
    }

    void WinCondition()
    {
        SceneManager.LoadScene("WinCondition");
    }

    void MoveEnemy(Vector2 dir)
    {
        rb.MovePosition((Vector2)transform.position + (dir*moveSpeed*Time.deltaTime));
    }
}
