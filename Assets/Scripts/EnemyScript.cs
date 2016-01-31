using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	public int hitPoints = 30;

	void OnTriggerEnter2D(Collider2D collide)
	{
		if (collide.gameObject.tag == "PlayerBullet")
		{
			hitPoints -= 10;
			Debug.Log("Enemy Hit by Player Bullet");
		}
	}
}
