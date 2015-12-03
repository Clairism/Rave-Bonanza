﻿using UnityEngine;
using System.Collections;

public class VomitManMoving : folksMoving {

	public bool vomiting;
	private float speedChange;
	

	public override void Start () {

		speed = 8f;
		vomiting = false;

		speedChange = 20f;

		//particle = GetComponentInChildren(ParticleEmitter);

	}

	public override void Update () {

		if(vomiting == true){
			//slow down speed
			GameObject.FindGameObjectWithTag("Player").GetComponent<playerController>().playerSpeed -= speedChange;
			//vomit effect

			Invoke ("SpeedBack", 8f);

			vomiting = false;
		}
	
	}
	

	//public void Play(bool withChildren = true);

	void SpeedBack(){

		GameObject.FindGameObjectWithTag("Player").GetComponent<playerController>().playerSpeed += speedChange;

	}
}
