using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	public int hitPoints = 30;
	public float speed = 3f;
	public Transform Player;

	void OnTriggerEnter2D(Collider2D collide)
	{
		if (collide.gameObject.tag == "PlayerBullet")
		{
			hitPoints -= 10;
			Debug.Log("Enemy Hit by Player Bullet");
		}
		if (collide.gameObject.tag == "Player") 
		{
			transform.LookAt(Player);
			transform.position += Vector3.up * Time.deltaTime * speed;
		}
				
	}
	void Update () {
		if (hitPoints >= 0 && hitPoints <= 10) {
			speed = 0f;
//			anim = GetComponent<Animator> ();
			Debug.Log ("Enemy is stunned");
		}

		if (hitPoints <= 0) {
			Destroy (this.gameObject);
			Debug.Log ("Dead");

		}

	}
}
