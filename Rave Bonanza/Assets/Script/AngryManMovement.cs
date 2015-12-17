using UnityEngine;
using System.Collections;

public class AngryManMovement : folksMoving
{

	GameObject player;
	private float chaseSpeed;
	private float normalSpeed;
	bool isHit;
	bool isAngry;

	public override void Start ()
	{
		
		speed = 80f;
		normalSpeed = 80f;
		rotationRange = 400f;
		timeGap = 0.3f;


		isHit = false;
		isAngry = true;
		chaseSpeed = 100f;

		player = GameObject.FindGameObjectWithTag ("Player");

	}
	
	public override void Update ()
	{
		
		Moving ();



		if (isHit) {

			transform.LookAt (player.transform);
			//transform. (chaseSpeed * Vector3.forward * Time.deltaTime);
			//GetComponent<Rigidbody> ().AddForce (transform.forward * speed);
			//transform.position += new Vector3(0, chaseSpeed * Time.deltaTime, 0);
			transform.forward *= chaseSpeed;
			isAngry = false;

			Invoke ("StopChasing", 8f);
		}
	}

	void OnTriggerEnter (Collider other)
	{

		if (other.tag == "Player" && isAngry) {
			isHit = true;

			//player.GetComponent<Rigidbody>().AddForce(transform.forward * -8f);
			//transform.LookAt (player.transform);
			//player.transform.Translate (Vector3.forward * -10f);

			Debug.Log ("Hit.");
			
		}

	}

	void StopChasing ()
	{

		isHit = false;
		speed = normalSpeed;

		Invoke ("CanChaseAgain", 3f);

	}

	void CanChaseAgain ()
	{

		isAngry = true;

	}

}
