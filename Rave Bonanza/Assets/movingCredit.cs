using UnityEngine;
using System.Collections;

public class movingCredit : MonoBehaviour {
	
	void Update () {

		transform.Translate (transform.up * 1.2f * Time.deltaTime);
	
	}
}
