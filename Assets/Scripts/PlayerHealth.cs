using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	public int hitPoints = 70;

	void OnGUI()
	{
		GUI.Box(new Rect(10, 10, 68, 24), "HP: " + hitPoints.ToString());
	}
}
