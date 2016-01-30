using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
// And Shooting and shit

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

		if (Input.GetKey("space"))
		{
			Fire();
		}

	}		
}
	