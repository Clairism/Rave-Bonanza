using UnityEngine;
using System.Collections;

public class AngryManMovement : folksMoving {

	Transform playerPosition;
	private float chaseSpeed;
	bool isHit;
	bool isAngry;

	public override void Start () {
		
		speed = 80f;
		rotationRange = 400f;
		timeGap = 0.3f;


		isHit = false;
		isAngry = true;
		chaseSpeed = 18f;

	}
	
	public override void Update () {
		
		Moving();


		playerPosition = GameObject.Find ("Player").transform;

		if (isHit) {

			transform.LookAt (playerPosition);
			transform.Translate (chaseSpeed * Vector3.forward * Time.deltaTime);

			isAngry = false;

			Invoke ("StopChasing", 8f);
		}
	}

	void OnTriggerEnter(Collider other){

		if(other.tag == "Player" && isAngry){
			isHit = true;
			
			Debug.Log ("Hit.");
			
		}

	}

	void StopChasing(){

		isHit = false;

		Invoke ("CanChaseAgain", 3f);

	}

	void CanChaseAgain(){

		isAngry = true;

	}

}
