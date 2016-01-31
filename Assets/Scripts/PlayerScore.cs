using UnityEngine;
using System.Collections;

public class PlayerScore : MonoBehaviour {
	public int score = 0;
		
	void OnGUI ()
	{
		GUI.Box(new Rect(10, 34, 68, 24), "Score: " + score.ToString());
	}
		
}