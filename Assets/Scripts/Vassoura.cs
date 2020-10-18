using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vassoura : MonoBehaviour
{
    Animator anim;
    public GameObject vassoura;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(vassoura);
            player.GetComponent<Animator>().SetBool("Vassoura", true);
        }
    }
}
