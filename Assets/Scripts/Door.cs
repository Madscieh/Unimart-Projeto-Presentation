using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door, playerKey, interact;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (playerKey.activeSelf    )
            {
                interact.SetActive(true);
                if (Input.GetKey("e"))
                {
                    //Destroy(playerKey);
                    //playerKey.SetActive(false);
                    Destroy(door);
                    interact.SetActive(false);
                }

            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            interact.SetActive(false);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
