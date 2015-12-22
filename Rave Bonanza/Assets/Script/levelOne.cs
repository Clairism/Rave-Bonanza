using UnityEngine;
using System.Collections;

public class levelOne : MonoBehaviour {

	GameObject levelTriggered;
	int i;

	void Start(){
		i = Application.loadedLevel;
	}

	void Update () {

		levelTriggered = GameObject.Find ("Exit door");

	if (levelTriggered.GetComponent<nextLevel>().triggered && Input.GetKey (KeyCode.S)) {
			Application.LoadLevel ("Claire scene");
		}
	
	}
}
