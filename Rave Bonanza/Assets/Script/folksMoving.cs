using UnityEngine;
using System.Collections;

public class folksMoving : MonoBehaviour {

	public float speed;

	public Vector3 wayPoint;
	public float Range;
	public float direction;

	void Start () {

		speed = 15f;

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
			//wayPoint =  new Vector3(Random.Range(transform.position.x - Range, transform.position.x + Range), 1, Random.Range(transform.position.z - Range, transform.position.z + Range));
			wayPoint= transform.localPosition + Random.insideUnitSphere * 30;
			wayPoint.y = 1;

			transform.LookAt(wayPoint);
			//Debug.Log(wayPoint + " and " + (transform.position - wayPoint).magnitude);
		}
	
}
