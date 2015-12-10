using UnityEngine;
using System.Collections;

public class VomitTrigger : MonoBehaviour
{
	

	void OnTriggerEnter (Collider other)
	{

		if (other.tag == "Player") {
			GetComponentInParent<VomitManMoving> ().vomiting = true;

			if (GetComponentInParent<VomitManMoving> ().vomitTimer >= 1.5f) {
				GetComponentInParent<VomitManMoving> ().hit = true;

				GetComponentInParent<VomitManMoving> ().vomitTimer = 0f;
			}
			Debug.Log ("Hit.");

		}
		
	}
}


