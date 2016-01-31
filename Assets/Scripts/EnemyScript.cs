using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	public int hitPoints = 30;
	public float speed = 3f;
	public Transform player;

	public int score = 0;

	private float Distance = 2f;
	private float Range;

	void Start()
	{
		Debug.Log(Range);
	}


	void OnGUI ()
	{
		GUI.Box(new Rect(10, 34, 68, 24), "Score: " + score);
	}

	void OnTriggerEnter2D(Collider2D collide)
	{
		if (collide.gameObject.tag == "PlayerBullet")
		{
			hitPoints -= 10;
			Debug.Log("Enemy Hit by Player Bullet");
		}

		if (collide.gameObject.tag == "Net" && hitPoints <= 10) {
			score++;
			Destroy (this.gameObject);
			Debug.Log ("Captured!");
		}
				
	}
		
	void Update () {
		if (hitPoints >= 0 && hitPoints <= 10) {
			speed = 0f;
			// anim = GetComponent<Animator> ();
			Debug.Log ("Enemy is stunned");
		}

		if (hitPoints <= 0) {
			Destroy (this.gameObject);
			Debug.Log ("Dead");
		}

		Range = Vector2.Distance(transform.position, player.position);

		if (Range <= Distance)
		{
			Debug.Log(Range);
			transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);		
		}

	}
}
