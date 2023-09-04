using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    /// Fecha o jogo
    public void Exit() {
        Application.Quit();
    }

     public void IniciarJogo()
    {
        SceneManager.LoadScene("1fase");
    }

     public void Sobre()
    {
        SceneManager.LoadScene("sobre");
    }

}



  
  

   
