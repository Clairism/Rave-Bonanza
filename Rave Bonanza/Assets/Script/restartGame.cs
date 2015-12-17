using UnityEngine;
using System.Collections;

public class restartGame : MonoBehaviour {


	void Update () {

		if (Input.GetKey (KeyCode.S)) {
			Application.LoadLevel(1);
		}
	}
}
