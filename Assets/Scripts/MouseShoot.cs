using UnityEngine;
using System.Collections;

public class MouseShoot : MonoBehaviour 
{
	public GameObject bullet;
	public GameObject net;

	public float speed    = 5.0f;
	public bool  pause    = true;

	Animator anim;

	void Start() 
	{
		anim = GetComponent<Animator>();
	}

	void Update() 
	{
		if (Input.GetMouseButtonDown(0)) 
		{
			MouseFire(bullet);
			AnimatePlayer();
		}

		if (Input.GetMouseButtonDown(1)) 
		{
			MouseFire(net);
			AnimatePlayer();
		}
	}

	void MouseFire(GameObject weapon)
	{
		Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
		Vector2 myPos = new Vector2(transform.position.x,transform.position.y);
		Vector2 direction = target - myPos;
		direction.Normalize(); // Normalize ensures the Vector has a Magnitude of 1.
		Quaternion rotation = Quaternion.Euler(0,0,Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90);
		GameObject projectile = (GameObject) Instantiate(weapon,myPos,rotation);
		projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;
	}

	void AnimatePlayer()
	{
		anim.Play("PlayerAttack");
		StartCoroutine(AnimationPause());
		anim.Play("PlayerIdle");
		StartCoroutine(AnimationPause());
	}

	// Cheap Animation Change Fix that should be corrected in the Animator Controller.
	public IEnumerator AnimationPause()
	{
		pause = false;
		yield return new WaitForSeconds(0.5f);
		pause = true;
	}
}
