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

		rigidbody.MovePosition(rigidbody.position + movementVector * speed * Time.deltaTime);

		if (Input.GetKey("space"))
		{
			Fire();
		
	}


		}

	}
