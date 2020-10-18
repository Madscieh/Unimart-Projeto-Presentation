using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickPickup : MonoBehaviour
{
    Animator anim;

    //public GameObject stickPickup;
    public GameObject stick, stickPickup, spaceInteract;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(stickPickup);
            stick.SetActive(true);
            spaceInteract.SetActive(true);
            player.GetComponent<Animator>().SetBool("Vassoura", true);
            //StartCoroutine(SpaceActivate());
        }

    }

    /*private void FixedUpdate()
    {
        if (spaceInteract.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("space");
                //spaceInteract.SetActive(false);
                Destroy(spaceInteract);
            }
        }
        
    }

    IEnumerator SpaceActivate()
    {
        spaceInteract.SetActive(true);
        yield return new WaitForSeconds(5f);
        spaceInteract.SetActive(false);
        //Destroy(spaceInteract);
    }*/
}
