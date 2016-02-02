using UnityEngine;
using System.Collections;

public class YouLose : MonoBehaviour {

	void OnGUI () {
		GUI.Box(new Rect(10,160,150,90), "YOU LOSE!");

		if(GUI.Button(new Rect(35,185,100,20), "Try Again?")) {
			Application.LoadLevel("Main");
		}

		if(GUI.Button(new Rect(35,205,100,20), "Quit Game")) {
			Application.Quit();
		}
	}
}
