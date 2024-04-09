using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    [SerializeField]private string nomedoLevel;
    [SerializeField]private string nomedoLevel2;
    [SerializeField]private GameObject painelMenuPrincipal;
    
    public void Jogar()
    {
        SceneManager.LoadScene(nomedoLevel);
    }
    public void FecharOpcoes()
    {
        painelMenuPrincipal.SetActive(true);
        SceneManager.LoadScene(nomedoLevel2);
        
    }
    
}
