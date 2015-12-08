using UnityEngine;
using System.Collections;

public class VomitManMoving : folksMoving {

	public bool vomiting;
	private float speedChange;

	public Transform hitPoint;
		
	float currentPlayerSpeed;

	public override void Start () {

		speed = 10f;
		rotationRange = 200f;
		timeGap = 2f;


		vomiting = false;
		speedChange = 20f;

	}

	public override void Update () {

		//transform.position += transform.TransformDirection(Vector3.forward) * speed *Time.deltaTime;

		Moving();

		currentPlayerSpeed = GameObject.FindGameObjectWithTag ("Player").GetComponent<playerController>().playerSpeed;

		if (vomiting == true && currentPlayerSpeed >= 0) {
			//slow down speed
			GameObject.FindGameObjectWithTag ("Player").GetComponent<playerController> ().playerSpeed -= speedChange;
			
			Invoke ("SpeedBack", 8f);
			
			//vomit particle effect

			//transform.LookAt(hitPoint);
			GetComponentInChildren<ParticleSystem>().Play();
					
			vomiting = false;

			Debug.Log ("vomitting");
		}
	
	}



	void SpeedBack(){

		GameObject.FindGameObjectWithTag("Player").GetComponent<playerController>().playerSpeed = 25f;

	}
}
