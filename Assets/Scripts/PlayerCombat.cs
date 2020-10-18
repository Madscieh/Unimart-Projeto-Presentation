using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator anim;

    public Transform arma;
    public LayerMask inimigoLayer;

    public float alcance = 0.5f;
    public int dano = 40;
     
    public float taxadeAtaque = 2f;
    float tempoProximoAtaque = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= tempoProximoAtaque)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
                tempoProximoAtaque = Time.time + 1f / taxadeAtaque;
            }
        }
    }

    void Attack()
    {
        anim.SetTrigger("Ataque");
        Collider2D[] acerto = Physics2D.OverlapCircleAll(arma.position, alcance, inimigoLayer);
        foreach(Collider2D inimigo in acerto)
        {
            inimigo.GetComponent<Monstro>().LevaDano(dano);
            Debug.Log("Acertou");
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (arma == null)
            return;
        Gizmos.DrawWireSphere(arma.position, alcance);
    }
}
