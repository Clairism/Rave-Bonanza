using UnityEngine;
using System.Collections;

public class nextLevel : MonoBehaviour {

	int currentLevel;

	void Start () {

	currentLevel = Application.loadedLevel;

	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey (KeyCode.R)){
			Application.LoadLevel(currentLevel);
		}
	
	}

	void OnTriggerEnter(Collider other){

		GameObject.Find ("timer").GetComponent<gameTimer>().stopTimer = true;


	}
}
