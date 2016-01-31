using UnityEngine;
using System.Collections;
using System;

public class EnemyMove : MonoBehaviour {

    protected Vector2 velocity;
    public Transform _transform;
    public float distance = 3f;
    public float speed = 1f;
    Vector2 _originalPosition;
    bool isGoingLeft = false;
    public float distFromStart;

	// Use this for initialization
	public void Start () {

        _originalPosition = gameObject.transform.position;
        _transform = GetComponent<Transform>();
        velocity = new Vector2(speed, 0);
        _transform.Translate(velocity.x * Time.deltaTime, 0,0);
	}
	
	// Update is called once per frame
	void Update () {

        distFromStart = transform.position.x - _originalPosition.x;

        if (isGoingLeft)
        {
            if (distFromStart < -distance)
                SwitchDirection();

            _transform.Translate(-velocity.x * Time.deltaTime, 0, 0);
        }
        else
        {
            if (distFromStart > distance)
                SwitchDirection();

            _transform.Translate(velocity.x * Time.deltaTime, 0, 0);
        }
	}

    void SwitchDirection()
    {
        isGoingLeft = !isGoingLeft;
    }
}
