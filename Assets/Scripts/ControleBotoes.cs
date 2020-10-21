using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleBotoes : MonoBehaviour
{
    public void IniciarJogo()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void SairJogo()
    {
        Application.Quit();
        UnityEngine.Debug.Log("Game is exiting");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}