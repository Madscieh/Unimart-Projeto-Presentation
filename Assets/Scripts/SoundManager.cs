using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip CaixaArrastando, CaixaQuebrando, PortaAbrindo, PortaDestrancando, Chave;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        CaixaArrastando = Resources.Load<AudioClip>("arrastandocaixa");
        CaixaQuebrando = Resources.Load<AudioClip>("caixamadeiraquebrando");
        PortaAbrindo = Resources.Load<AudioClip>("portaabrindo");
        PortaDestrancando = Resources.Load<AudioClip>("portadestrancando");
        Chave = Resources.Load<AudioClip>("som chave");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "arrastandocaixa":
                audioSrc.PlayOneShot(CaixaArrastando);
                break;
            case "caixamadeiraquebrando":
                audioSrc.PlayOneShot(CaixaQuebrando);
                break;
            case "portaabrindo":
                audioSrc.PlayOneShot(PortaAbrindo);
                break;
            case "portadestrancando":
                audioSrc.PlayOneShot(PortaDestrancando);
                break;
            case "som chave":
                audioSrc.PlayOneShot(Chave);
                break;
        }
    }
}
