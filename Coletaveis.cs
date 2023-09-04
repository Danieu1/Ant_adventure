using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletaveis : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        /// Se está colidindo com o player
        if (collider.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }

  
}
