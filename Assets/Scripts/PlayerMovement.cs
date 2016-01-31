using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    // And Shooting and shit
	Rigidbody2D rigidbody;
	Animator anim;
	public float speed = 2.0f;
	PlayerHealth playerHealth;


	void Start () {
		rigidbody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}
		
	void Update () {
		Vector2 movementVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		rigidbody.MovePosition(rigidbody.position + movementVector * speed * Time.deltaTime);
	}


	void OnTriggerEnter2D(Collider2D collide)
	{
		if (collide.gameObject.tag == "Enemy")
		{
			playerHealth.hitPoints--;
			Debug.Log("HIT!");

		}
	}
}