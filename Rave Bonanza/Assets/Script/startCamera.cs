using UnityEngine;
using System.Collections;

public class startCamera : MonoBehaviour {

	void Update () {

		if (Input.GetKey (KeyCode.S)) {
			GetComponent<cameraLerping>().enabled = true;

			GameObject.Find ("control Intro").GetComponent<MeshRenderer>().enabled = true;
			GameObject.Find ("goal Intro").GetComponent<MeshRenderer>().enabled = true;

		}
	
	}
}
