using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField]private string nomedoLevel;
    [SerializeField]private GameObject painelMenuPrincipal;
    [SerializeField]private GameObject painelOpcoes;
    public void Jogar()
    {
        SceneManager.LoadScene(nomedoLevel);
    }
    public void AbrirOpcoes()
    {
        painelMenuPrincipal.SetActive(false);
        painelOpcoes.SetActive(true);
    }
    public void FecharOpcoes()
    {
        painelMenuPrincipal.SetActive(true);
        painelOpcoes.SetActive(false);
    }
    public void Sair()
    {
        
        Application.Quit();
    }

}
