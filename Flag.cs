using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Flag : MonoBehaviour
{
   
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player"){
            if (GameObject.FindGameObjectsWithTag("coletaveis").Length == 0){

                    SceneManager.LoadScene(0);
            } 
        } 
    }
}
