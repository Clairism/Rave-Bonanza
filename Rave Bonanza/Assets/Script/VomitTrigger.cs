using UnityEngine;
using System.Collections;

public class VomitTrigger : VomitManMoving {

	
	void OnTriggerEnter(Collider other){

		if(other.tag == "player"){
			vomiting = true;

			Debug.Log ("Hit.");

		}
		
	}
}
