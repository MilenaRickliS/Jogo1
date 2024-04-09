using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VidodoJogador : MonoBehaviour
{
    public Text PontosPlayer;
    public int vidaMaxima;
    public int vidaAtual;
    public Transform startPosition;
    // Start is called before the first frame update
    void Start()
    {
        vidaAtual = vidaMaxima;
        PontosPlayer.text = vidaAtual + " POINTS";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReceberDano(){
        vidaAtual -= 1;
        PontosPlayer.text = vidaAtual + " POINTS";
        transform.position = startPosition.position;
        if(vidaAtual <= 0){
            Debug.Log("Game over");
            Time.timeScale = 0;
            SceneManager.LoadScene("GameOver");
        }
    }
}
