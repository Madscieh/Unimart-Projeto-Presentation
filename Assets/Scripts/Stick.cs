using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    public Collider2D stickCollider;
    public Animator animator;
    public GameObject spaceInteraction;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        stickCollider = GetComponent<Collider2D>();
        stickCollider.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(stickHit());
            spaceInteraction.SetActive(false);
            //stickCollider.enabled=!stickCollider.enabled; (on and off..... ????!!!???)
        }
    }

    IEnumerator stickHit()
    {
        stickCollider.enabled = true;
        //animator.Play("StickHit");
        yield return new WaitForSeconds(1);
        stickCollider.enabled = false;
    }


}
