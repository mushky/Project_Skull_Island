using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	Camera playerCamera;
	public float screenScalar = 1.5f;
	public float linearInterpolation = 0.1f;

	void Start () 
	{
		playerCamera = GetComponent<Camera>();
	}


	void Update () 
	{
		playerCamera.orthographicSize = (Screen.height / 100f) / screenScalar;

		if (target)
		{
			transform.position = Vector3.Lerp(transform.position, target.position, linearInterpolation) + new Vector3(0, 0, -10);
		}
	}
}
