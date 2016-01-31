using UnityEngine;
using System.Collections;

public class YouLose : MonoBehaviour {

	void OnGUI () {
		GUI.Box(new Rect(10,10,100,90), "You Lose!");

		if(GUI.Button(new Rect(20,40,80,20), "Try Again?")) {
			Application.LoadLevel(1);
		}

		if(GUI.Button(new Rect(20,70,80,20), "Quit Game")) {
			Application.LoadLevel(2);
		}
	}
}
