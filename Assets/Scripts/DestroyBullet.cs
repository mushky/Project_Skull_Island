using UnityEngine;
using System.Collections;

public class DestroyBullet : MonoBehaviour {

	public float lifetime;

	void Start ()
	{
		Destroy (gameObject, lifetime);
	}
}
