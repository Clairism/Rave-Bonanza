﻿using UnityEngine;
using System.Collections;

public class VomitManMoving : folksMoving {

	public bool vomiting;
	private float speedChange;
	

	 void Start () {

		speed = 5f;
		Wander ();

		vomiting = false;

		speedChange = 20f;


	}

	void Update () {

		transform.position += transform.TransformDirection(Vector3.forward) * speed *Time.deltaTime;
		
		if((transform.position - wayPoint).magnitude < 2)
		{

			Wander();
			
		}

		if (vomiting == true) {
			//slow down speed
			GameObject.FindGameObjectWithTag ("Player").GetComponent<playerController> ().playerSpeed -= speedChange;
			
			Invoke ("SpeedBack", 8f);
			
			//vomit particle effect??
			vomiting = false;
		}
	
	}


	void SpeedBack(){

		GameObject.FindGameObjectWithTag("Player").GetComponent<playerController>().playerSpeed += speedChange;

	}
}
