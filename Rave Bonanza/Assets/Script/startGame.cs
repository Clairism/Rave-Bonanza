using UnityEngine;
using System.Collections;

public class startGame : MonoBehaviour {


	void Update () {

		if (Input.GetKey (KeyCode.S)) {
			Application.LoadLevel("Claire scene");
		}

	}
}
