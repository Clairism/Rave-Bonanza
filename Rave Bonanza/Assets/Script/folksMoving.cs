using UnityEngine;
using System.Collections;

public class folksMoving : MonoBehaviour {

	public float speed;

	public Vector3 wayPoint;
	public float direction;

	public float changeRange;

	void Start () {

		speed = 18f;

		Wander();

	}
	
	void Update () {

		transform.position += transform.TransformDirection(Vector3.forward) * speed *Time.deltaTime;

			if((transform.position - wayPoint).magnitude < 3)
			{
				// when the distance between us and the target is less than 3
				// create a new way point target
				Wander();

			}

	}
		
		public void Wander()
		{ 			
//		wayPoint =  new Vector3(Random.Range(transform.position.x - changeRange, transform.position.x + changeRange), 
//		                        Random.Range(transform.position.z - changeRange, transform.position.z + changeRange), 0);
			wayPoint = transform.position + Random.insideUnitSphere* 28;
			wayPoint.y = 0;

			transform.LookAt(wayPoint);
			//Debug.Log(wayPoint + " and " + (transform.position - wayPoint).magnitude);
		}

	void OnCollisionEnter(Collision hit){

		if (hit.gameObject.tag == "Floor") {
			Wander ();
		}

	}
	
}
