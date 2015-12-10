using UnityEngine;
using System.Collections;

public class VomitManMoving : folksMoving
{

	public bool vomiting;
	public bool hit;
	float currentPlayerSpeed;
	GameObject player;

	public float vomitTimer;
	public float vomitTiming;

	public override void Start ()
	{

		speed = 10f;
		rotationRange = 200f;
		timeGap = 2f;


		vomiting = false;
		hit = false;

		player = GameObject.FindGameObjectWithTag ("Player");

	}

	public override void Update ()
	{
		//transform.position += transform.TransformDirection(Vector3.forward) * speed *Time.deltaTime;

		Moving ();

		currentPlayerSpeed = player.GetComponent<playerController> ().playerSpeed;

		if (vomiting == true && currentPlayerSpeed >= 0) {
			//slow down speed
			player.GetComponent<playerController> ().playerSpeed = 5f;
			
			Invoke ("SpeedBack", 8f);
			
			//timer to LookAt

			if (hit) {

				transform.LookAt (player.transform.position);

				vomitTimer += Time.deltaTime;

				hit = false;
				}

			//vomit particle effect

			GetComponentInChildren<ParticleSystem> ().Play ();
					
			vomiting = false;

			Debug.Log ("vomitting");
		}
	
	}

	void SpeedBack ()
	{

		player.GetComponent<playerController> ().playerSpeed = 25f;

	}
}
