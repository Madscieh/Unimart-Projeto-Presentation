using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBox : MonoBehaviour
{
    public GameObject breakableBox;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Projectile")
        {
            Destroy(breakableBox);
            SoundManager.PlaySound("caixamadeiraquebrando");
        }
    }
}
