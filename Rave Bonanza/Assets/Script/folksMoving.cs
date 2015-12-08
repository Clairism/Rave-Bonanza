using UnityEngine;
using System.Collections;

public class folksMoving : MonoBehaviour
{

	public float speed;
	public float rotationSpeed;
	public float rotationRange;
	
	public float timer;

	public float timeGap;
	
	//Rigidbody rb;

	//public Transform startPoint;

	public virtual void Start ()
	{

		speed = 100f;
		timeGap = 0.6f;

		rotationRange = 300f;
		//Wander();
		//startPoint.position = transform.localPosition;
		//rb = GetComponent<Rigidbody>();
	}
	
	public virtual void Update ()
	{
		Moving();


	}

	
	public void Moving ()
	{
		timer += Time.deltaTime;
		
		GetComponent<Rigidbody> ().AddForce (transform.forward * speed);

		if (timer >= timeGap) {
			
			changeDirection ();
			timer = 0;
			
		}

	}
		
	public void changeDirection ()
	{ 			

		rotationSpeed = Random.Range (-rotationRange, rotationRange);
		GetComponent<Rigidbody> ().AddTorque (transform.up * rotationSpeed);


		/*
		wayPoint = transform.position + Random.insideUnitSphere* 28;
			wayPoint.y = 0;

			transform.LookAt(wayPoint);
			Debug.Log(wayPoint + " and " + (transform.position - wayPoint).magnitude);
			*/

	}


	public void OnCollisionEnter (Collision hit)
	{

		if (hit.gameObject.tag == "Floor") {
			changeDirection ();		
		}

	}
	
}
