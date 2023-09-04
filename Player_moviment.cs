using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_moviment : MonoBehaviour
{
	//-
	[SerializeField] Rigidbody2D rb;
	[SerializeField] float velocidade = 5;
	[SerializeField] Animator anime;
	[SerializeField] public int Hp = 3;
	private float scalaInicial;

	
	void Start(){
		scalaInicial = transform.localScale.x;
	}
	
	// Update is called once per frame
	void Update () {
		
		float hAxis = Input.GetAxisRaw("Horizontal") * velocidade;
		rb.velocity = new Vector2(hAxis*velocidade, rb.velocity.y);
		anime.SetBool("CheckMoviment", hAxis != 0f); // true quando eu estiver me movendo 

		if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 20);
        }
		 if (hAxis != 0)
        {
            Flip(hAxis);
        }
	}
	 void Flip(float hAxis)
    {
        transform.localScale = new Vector3(Mathf.Sign(hAxis)*scalaInicial, transform.localScale.y);
    }
	  public void TakeDamage(int dmg) 
    {
        Hp -= dmg;
        if (Hp <= 0) SceneManager.LoadScene(0);
	
    }


}
