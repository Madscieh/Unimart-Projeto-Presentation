using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject teleporter, player;
    public static int teleportCheck = 0;
    //private Collider2D stickCollider;
    // Start is called before the first frame update
    void Start()
    {
        //stickCollider = GetComponent<Stick>().stickCollider;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (teleportCheck == 1)
        {
            teleportCheck = 0;
            StartCoroutine(Teleport());
        }
    }

    IEnumerator Teleport()
    {
        
        yield return new WaitForSeconds(0.1f);
        player.transform.position = new Vector2(teleporter.transform.position.x, teleporter.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
