using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstro : MonoBehaviour
{
    public Animator anim;

    public int saudeMax = 100;
    int saudeAtual;

    // Start is called before the first frame update
    void Start()
    {
        saudeAtual = saudeMax;
    }

    public void LevaDano (int dano)
    {
        saudeAtual -= dano;

        anim.SetTrigger("Ferido");

        if (saudeAtual <= 0)
        {
            Desmaio();
        }
    }

    void Desmaio()
    {
        anim.SetBool("Desmaio", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}
