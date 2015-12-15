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
		rotationRange = 100f;
		timeGap = 3f;

		vomiting = false;
		hit = false;

		player = GameObject.FindGameObjectWithTag ("Player");

	}

	public override void Update ()
	{

		Moving ();

		currentPlayerSpeed = player.GetComponent<playerController> ().playerSpeed;

		if (vomiting == true && currentPlayerSpeed >= 0) {

			//slow down speed
			player.GetComponent<playerController> ().playerSpeed = 5f;
			
			Invoke ("SpeedBack", 3f);
			
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
