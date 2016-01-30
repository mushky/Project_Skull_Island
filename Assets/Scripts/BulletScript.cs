using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	float speed = 30.0f;

	void Update()
	{
		transform.position += Vector3.up * speed * Time.deltaTime;
	}
}
