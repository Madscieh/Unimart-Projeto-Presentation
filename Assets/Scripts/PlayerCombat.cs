using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator anim;



    public Transform arma;
    public Transform player;
    public LayerMask inimigoLayer;



    public float alcance = 0.5f;
    public int dano = 40;



    public float cadenciaDeAtaque = 2f;
    float tempoProximoAtaque = 0f;
    float horizontal;
    float vertical;



    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if (horizontal != 0 || vertical != 0)
            if (horizontal != 0)
                arma.position = new Vector3(horizontal / 2, 0, 0) + player.position;
            else
                arma.position = new Vector3(0, vertical, 0) + player.position;



        /*
        // Se estiver parado, não muda a posição da arma
        if (horizontal == 0 && vertical == 0)
        { }
        // Primeiro Quadrante
        else if (horizontal >= 0 && vertical >= 0)
        {
            if (Mathf.Abs(horizontal) >= Mathf.Abs(vertical))
                arma.position = new Vector3(0.5f, 0f, 0f) + player.position;
            if (Mathf.Abs(horizontal) < Mathf.Abs(vertical))
                arma.position = new Vector3(0f, 1f, 0f) + player.position;
        }
        // Segundo Quadrante
        else if (horizontal < 0 && vertical >= 0)
        {
            if (Mathf.Abs(horizontal) >= Mathf.Abs(vertical))
                arma.position = new Vector3(-0.5f, 0f, 0f) + player.position;
            if (Mathf.Abs(horizontal) < Mathf.Abs(vertical))
                arma.position = new Vector3(0f, 1f, 0f) + player.position;
        }
        // Terceiro Quadrante
        else if (horizontal < 0 && vertical < 0)
        {
            if (Mathf.Abs(horizontal) >= Mathf.Abs(vertical))
                arma.position = new Vector3(-0.5f, 0f, 0f) + player.position;
            if (Mathf.Abs(horizontal) < Mathf.Abs(vertical))
                arma.position = new Vector3(0f, -1f, 0f) + player.position;
        }
        // Quarto Quadrante
        else if (horizontal >= 0 && vertical < 0)
        {
            if (Mathf.Abs(horizontal) >= Mathf.Abs(vertical))
                arma.position = new Vector3(0.5f, 0f, 0f) + player.position;
            if (Mathf.Abs(horizontal) < Mathf.Abs(vertical))
                arma.position = new Vector3(0f, -1f, 0f) + player.position;
        }
        */



        if (Time.time >= tempoProximoAtaque)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
                //AttackBox();
                tempoProximoAtaque = Time.time + 1f / cadenciaDeAtaque;
            }
        }
    }
    void Attack()
    {
        anim.SetTrigger("Ataque");
        Collider2D[] acerto = Physics2D.OverlapCircleAll(arma.position, alcance, inimigoLayer);
        for (int indice = acerto.Length - 1; indice >= 0; indice--)
        {
            //Se vc tivesse feito uma classe com um detroy abstrato, não precisava
            //ficar checando para ver se tem o componente...
            if (acerto[indice].GetComponent<Monstro>() != null)
                acerto[indice].GetComponent<Monstro>().LevaDano(dano);
            else if (acerto[indice].GetComponent<BreakableBox>() != null)
                acerto[indice].GetComponent<BreakableBox>().DestroyBox();
        }
    }


    void AttackBox()
    {
        anim.SetTrigger("Ataque");
        Collider2D[] acertoBox = Physics2D.OverlapCircleAll(arma.position, alcance, inimigoLayer);
        for (int i = acertoBox.Length - 1; i >= 0; i--)
        {
            acertoBox[i].GetComponent<BreakableBox>().DestroyBox();
            Debug.Log("Destroi caixa");
            Debug.Log(i);
        }
    }


    private void OnDrawGizmosSelected()
    {
        if (arma == null)
            return;
        Gizmos.DrawWireSphere(arma.position, alcance);
    }
}