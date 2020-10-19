using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue, interact;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (Input.GetKey("e"))
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            }
        }
    }
}
