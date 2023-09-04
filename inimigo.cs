using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{
    [SerializeField] private int contactDmg;//
    [SerializeField] private float speed;
    [SerializeField] private float detectRange = 10f;
    [SerializeField] private Transform player;
    [SerializeField] private Rigidbody2D rig;//
    [SerializeField] private BoxCollider2D Headcolider;//


    private float scalaInicial;

    void Start()
    {
        scalaInicial = transform.localScale.x;
        GameObject p = GameObject.FindWithTag("Player");
        if (p != null) 
        {
            player = p.GetComponent<Transform>();
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPos = player.position;
        Vector2 direction = playerPos - (Vector2)transform.position;
        if (direction.magnitude <= detectRange)
        {
            direction.Normalize();
            rig.velocity = direction * speed;

            transform.localScale = new Vector2(Mathf.Sign(rig.velocity.x)*scalaInicial, transform.localScale.y);
        }
        else
        {
            rig.velocity = Vector2.zero;
        }
    }

       public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            
        
             if(col.otherCollider == Headcolider) //Se o colisor que bateu no player for o head collider:
            {
                Destroy(this.gameObject);
            }
            else
            {
            //Dar dano
                col.gameObject.GetComponent<Player_moviment>().TakeDamage(contactDmg);

            }
        }

    }

      public void TakeDamage(int dmg)
    {
       Destroy(this.gameObject);
    }

}