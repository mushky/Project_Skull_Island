using UnityEngine;
using System.Collections;

public class IntroGUI : MonoBehaviour {

	void OnGUI () {
		GUI.Box(new Rect(250,100,200,90), "Begin the Sacrifice!");

		if(GUI.Button(new Rect(315,130,80,20), "Start Game")) 
		{
			Application.LoadLevel("Main");
		}

		if(GUI.Button(new Rect(315,150,80,20), "Quit Game")) 
		{
			Application.Quit();
		}
	}
}

