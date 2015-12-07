using UnityEngine;
using System.Collections;

public class AngryManMovement : folksMoving {

	Transform playerPosition;
	private float chaseSpeed;
	bool isHit;
	bool isAngry;

	void Start () {
		
		speed = 8f;
		Wander ();

		isHit = false;
		isAngry = true;
		chaseSpeed = 18f;

	}
	
	void Update () {
		
		transform.position += transform.TransformDirection (Vector3.forward) * speed * Time.deltaTime;
		
		if ((transform.position - wayPoint).magnitude < 8 && isHit == false) {
			
			Wander ();
			
		}

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
