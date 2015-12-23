using UnityEngine;
using System.Collections;

public class movingCredit : MonoBehaviour {

	void Start(){
		Time.timeScale = 1;
	}
	
	void Update () {

		transform.Translate (transform.up * 1.2f * Time.deltaTime);
	
	}
}
