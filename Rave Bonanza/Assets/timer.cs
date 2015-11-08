using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {
	string timerCount;

	float countUpTimer = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		countUpTimer += Time.deltaTime;

//		GUIText.text = "" + countUpTimer;
	
	}
}
