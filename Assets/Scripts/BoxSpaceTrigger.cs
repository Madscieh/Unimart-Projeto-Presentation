using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpaceTrigger : MonoBehaviour
{
    public GameObject spaceTrigger;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player")
        spaceTrigger.SetActive(true);   
    }
}
