using UnityEngine;
using System.Collections;

public class VomitTrigger : MonoBehaviour {
	

	void OnTriggerEnter(Collider other){

		if(other.tag == "Player"){
			GetComponentInParent<VomitManMoving>().vomiting = true;

			//hitPoint = GetComponentInParent<Transform>();

			Debug.Log ("Hit.");

		}
		
	}
}


