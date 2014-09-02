using UnityEngine;
using System.Collections;

public class spinScript : MonoBehaviour {

	public GUIText cubeText;

	public int speed;
	public int spinDuration;
	private long startTime;



	// Use this for initialization
	void Start () {

		startTime = (long) Time.time;

	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate(Vector3.up, speed * Time.deltaTime);

		long duration = (long) Time.time - startTime;
		checkForExit (duration);

	}

	void checkForExit(long duration){

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
