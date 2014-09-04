using UnityEngine;
using System.Collections;

public class spinScript : MonoBehaviour {

	private long startTime;

	public GUIText cubeText;
	public GUIText messText;	
	public int spinDuration;
	public int speed;
	
	// Use this for initialization
	void Start () {

		startTime = (long) Time.time;
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate(Vector3.up, speed * Time.deltaTime);


		// Checking for when to end the player
		long duration = (long) Time.time - startTime;
		checkForExit (duration);
	}

	void JavaMessage(string message) { 
		Debug.Log("PRA, message from native app: " + message); 
		messText.text = message;
	}

	void checkForExit(long duration){

		// check for end of countdown
		// set countdown text
		if (duration > spinDuration) {
	
			// exit the application
			cubeText.text = "App Exited";
			Application.Quit ();
		} else {
					
			long remaingingTime = spinDuration - duration;			
			cubeText.text = "App will close in: "+remaingingTime;
		}
	}	
}
