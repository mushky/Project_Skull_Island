using UnityEngine;
using System.Collections;

public class YouWin : MonoBehaviour {

	void OnGUI () {
		GUI.Box(new Rect(10,10,100,90), "You Win!");

		if(GUI.Button(new Rect(20,40,80,20), "Play Again?")) {
			Application.LoadLevel(1);
		}

		if(GUI.Button(new Rect(20,70,80,20), "Quit Game")) {
			Application.LoadLevel(2);
		}
	}
}
