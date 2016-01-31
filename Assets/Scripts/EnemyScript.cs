using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	public int hitPoints = 30;
	public float speed = 3f;

	public float Distance = 2f;
	public float Range;

	public Transform player;
	public AudioSource Captured;

	public PlayerScore playerScore;
	Animator anim;

	void Start()
	{
		Debug.Log(Range);
		anim = GetComponent<Animator>();
		Captured = GetComponent<AudioSource>();
	}
		
	void OnTriggerEnter2D(Collider2D collide)
	{
		if (collide.gameObject.tag == "PlayerBullet")
		{
			hitPoints -= 10;
			Debug.Log("Enemy Hit by Player Bullet");
			Captured.Play();
		}

		if (collide.gameObject.tag == "Net" && hitPoints <= 10) 
		{
			Debug.Log ("Captured!");
			playerScore.score+=5;
			Captured.Play();
			transform.position = new Vector2(5000,5000);
		}
	}
		
	void Update () 
	{
		if (hitPoints <= 10) 
		{
			anim.Play("EnemyStunned");
			Debug.Log ("Enemy is stunned");
		}

		if (hitPoints <= 0) 
		{
			Captured.Play();
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
