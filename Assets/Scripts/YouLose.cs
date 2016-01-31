using UnityEngine;
using System.Collections;

public class YouLose : MonoBehaviour {

	void OnGUI () {
		GUI.Box(new Rect(10,10,150,90), "You Lose!");

		if(GUI.Button(new Rect(20,40,100,20), "Try Again?")) {
			Application.LoadLevel("Main");
		}

		if(GUI.Button(new Rect(20,70,100,20), "Quit Game")) {
			Application.Quit();
		}
	}
}
