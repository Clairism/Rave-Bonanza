using UnityEngine;
using System.Collections;

public class VomitTrigger : VomitManMoving {

	
	void OnTriggerEnter(Collider other){

		if(other.tag == "Player"){
			vomiting = true;

			Debug.Log ("Hit.");

		}
		
	}
}
