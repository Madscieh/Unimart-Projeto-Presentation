using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaBox : MonoBehaviour
{
    public Sprite PortaAberta;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GetComponent<BoxCollider2D>().enabled = false;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = PortaAberta;
            SoundManager.PlaySound("portaabrindo");
        }
    }
}
