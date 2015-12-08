using UnityEngine;
using System.Collections;

public class folksMoving : MonoBehaviour {

	public float speed;
	public float rotationSpeed;


	//public Vector3 wayPoint;

	//public float changeRange;

	float timer;

	//Rigidbody rb;

	//public Transform startPoint;

	void Start () {

		speed = 100f;

		//Wander();
		//startPoint.position = transform.localPosition;
		//rb = GetComponent<Rigidbody>();
	}
	
	void Update () {
		timer += Time.deltaTime;

		GetComponent<Rigidbody>().AddForce(transform.forward * speed);

		/*
			if((transform.position - wayPoint).magnitude < 15)
			{
				// when the distance between us and the target is less than 3
				// create a new way point target
				Wander();

			}
			*/

		if(timer >= 0.6f){

			changeDirection();
			timer = 0;

		}

	}
		
		public void changeDirection()
		{ 			

		rotationSpeed = Random.Range (-300f, 300f);
		GetComponent<Rigidbody>().AddTorque(transform.up * rotationSpeed);


		/*
		wayPoint = transform.position + Random.insideUnitSphere* 28;
			wayPoint.y = 0;

			transform.LookAt(wayPoint);
			Debug.Log(wayPoint + " and " + (transform.position - wayPoint).magnitude);
			*/

		}

	void OnCollisionEnter(Collision hit){

		if (hit.gameObject.tag == "Floor") {
			changeDirection();		
		}

	}
	
}
