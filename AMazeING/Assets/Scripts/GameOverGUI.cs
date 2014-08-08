using UnityEngine;
using System.Collections;

public class GameOverGUI : MonoBehaviour {

	public GUISkin mySkin;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI(){
		GUI.skin = mySkin;
		DrawStartMenu ();
		
		
	}
	
	void DrawStartMenu(){
		
		//specify window size
		float boxWidth = Screen.width * .8f;
		float boxHeight = Screen.height * .8f;
		
		//center box
		float boxLeft = (Screen.width/2)-(boxWidth/2);
		float boxTop = (Screen.height / 2) - (boxHeight / 2);
		
		
		Rect menuBox = new Rect (boxLeft,boxTop,boxWidth,boxHeight);
		
		GUI.BeginGroup (menuBox, "Game Over","Box");
		float buttonWidth = 200f;
		float buttonHeight = 30f;
		
		float buttonLeft = (boxWidth / 2) - (buttonWidth / 2);
		float buttonTop = 400f;
		Rect startButtonRect = new Rect (buttonLeft, buttonTop, buttonWidth, buttonHeight);
		
		if (GUI.Button (startButtonRect, "Start Over")) {
			Application.LoadLevel("gusScene");
		}	
		
		
		GUI.EndGroup ();
		
		
	}
}
