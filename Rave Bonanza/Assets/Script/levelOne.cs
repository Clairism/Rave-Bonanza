using UnityEngine;
using System.Collections;

public class levelOne : MonoBehaviour {

	GameObject levelTriggered;

	void Update () {

		levelTriggered = GameObject.Find ("Exit door");

	if (levelTriggered.GetComponent<nextLevel>().triggered && Input.GetKey (KeyCode.S)) {
			Application.LoadLevel ("Claire scene");
		}
	
	}
}
