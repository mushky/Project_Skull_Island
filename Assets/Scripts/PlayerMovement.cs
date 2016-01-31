using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    // And Shooting and shit
	Rigidbody2D rigidbody;
	Animator anim;

	public float speed = 2.0f;
	public int hitPoints = 70;

	void OnGUI()
	{
		GUI.Box(new Rect(10, 10, 68, 24), "HP: " + hitPoints.ToString());
	}

	void Start () {
		rigidbody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}
		
	void Update () {
		Vector2 movementVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		rigidbody.MovePosition(rigidbody.position + movementVector * speed * Time.deltaTime);

		if (hitPoints <= 0) {
			Debug.Log ("Dead");
			Application.LoadLevel("YouLose");

		}
	}

	void OnTriggerEnter2D(Collider2D collide)
	{
		if (collide.gameObject.tag == "Enemy")
		{
			hitPoints -= 10;
			Debug.Log("You have been hit by the enemy");
		}
	}

}