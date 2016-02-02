using UnityEngine;
using System.Collections;
using System;

public class EnemyMove : MonoBehaviour {

    protected Vector2 velocity;
    public Transform ObjectPosition;
    public float distance = 3f;
    public float speed = 1f;
    Vector2 OriginalPosition;
    bool IsGoingLeft = false;
    public float distFromStart;
	public EnemyScript enemyScript;

	public void Start() 
	{
        OriginalPosition = gameObject.transform.position;
		ObjectPosition = GetComponent<Transform>();
        velocity = new Vector2(speed, 0);
		ObjectPosition.Translate(velocity.x * Time.deltaTime, 0,0);
	}
	
	void Update() 
	{

		distFromStart = transform.position.x - OriginalPosition.x;

        if (IsGoingLeft)
        {
            if (distFromStart < -distance)
                SwitchDirection();

			ObjectPosition.Translate(-velocity.x * Time.deltaTime, 0, 0);
        }
        else
        {
            if (distFromStart > distance)
                SwitchDirection();

			ObjectPosition.Translate(velocity.x * Time.deltaTime, 0, 0);
        }

		if (enemyScript.hitPoints <= 10)
		{
			speed = 0;

		}
	}

    void SwitchDirection()
    {
        IsGoingLeft = !IsGoingLeft;
    }
}
