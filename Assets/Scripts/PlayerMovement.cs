using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
// And Shooting and shit
	Rigidbody2D rigidbody;
	Animator anim;
	public float speed = 5.0f;

	// Shooting Mechanics
	public float fireRate = 1f;
	public float delay = 1f;
	public GameObject shot;
	public Transform shotSpawn;

	void Start () {
		rigidbody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}
		
	void Fire ()
	{
		Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
	}

	void Update () {
		Vector2 movementVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		/*
		if (movementVector != Vector2.zero) 
		{
			anim.SetBool("isWalking", true);
			anim.SetFloat("input_x", movementVector.x);
			anim.SetFloat("input_y", movementVector.y);
		}
		else
		{
			anim.SetBool("isWalking", false);
		}
		*/
		rigidbody.MovePosition(rigidbody.position + movementVector * speed * Time.deltaTime);

		if (Input.GetKey("space"))
		{
			Fire();
		}
	}
}
/*
	public float speed = 5.0f;
	public int hitPoints = 70;

	public GameObject shot;
	public Transform shotSpawn;

	public float fireRate = 1f;
	public float delay = 1f;

	void Fire ()
	{
		Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
	}

	void RotateLeft () 
	{
		transform.Rotate (Vector3.forward * 5);
	}

	void RotateRight () 
	{
		transform.Rotate (Vector3.forward * -5);
	}

	void Update() 
	{
		if (Input.GetKey("w"))
		{
			transform.position += Vector3.up * speed * Time.deltaTime;
		}

		if (Input.GetKey("s"))
		{
			transform.position += Vector3.down * speed * Time.deltaTime;
		}

		if (Input.GetKey("a"))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}

		if (Input.GetKey("d"))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}

		if (Input.GetKey("q"))
		{
			RotateLeft();
		}

		if (Input.GetKey("e"))
		{
			RotateRight();
		}
			
		if (Input.GetKey("space"))
		{
			Fire();
		}
	}		
}

*/	