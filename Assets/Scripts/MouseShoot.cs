using UnityEngine;
using System.Collections;

public class MouseShoot : MonoBehaviour {

	public GameObject bullet;
<<<<<<< HEAD
	public float speed = 5.0f;
	public GameObject net;
=======
	public float speed = 6.0f;
	public bool pause = true;
	Animator anim;
>>>>>>> 80b21f8cecb9068f1bf56178a131d8c8e67ba8bb

	void Start () {
		anim = GetComponent<Animator>();
	}

	void Update () {
		if (Input.GetMouseButtonDown(0)) 
		{
			Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
			Vector2 myPos = new Vector2(transform.position.x,transform.position.y);
			Vector2 direction = target - myPos;

			direction.Normalize();

			Quaternion rotation = Quaternion.Euler(0,0,Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90) ;
			GameObject projectile = (GameObject) Instantiate(bullet,myPos, rotation);
			projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;

<<<<<<< HEAD
		}

		if (Input.GetMouseButtonDown(1)) {
			Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
			Vector2 myPos = new Vector2(transform.position.x,transform.position.y);
			Vector2 direction = target - myPos;
			direction.Normalize();
			Quaternion rotation = Quaternion.Euler(0,0,Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90) ;
			GameObject projectile = (GameObject) Instantiate(net, myPos, rotation);
			projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;

=======
			// Attack Animation
			anim.Play("PlayerAttack");
			StartCoroutine(AnimationPause());
			anim.Play("PlayerIdle");
			StartCoroutine(AnimationPause());

		}
	}
>>>>>>> 80b21f8cecb9068f1bf56178a131d8c8e67ba8bb

	// Cheap Animation Change Fix
	public IEnumerator AnimationPause()
	{
		pause = false;
		yield return new WaitForSeconds(0.5f);
		pause = true;
	}
}
