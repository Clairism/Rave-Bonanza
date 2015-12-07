using UnityEngine;
using System.Collections;

public class folksMoving : MonoBehaviour {

	public float speed;

	public Vector3 wayPoint;

//	public float xMax;
//	public float zMax;
//	public float xMin;
//	public float zMin;
	public float Range;
	//private float z;
//	private float timeGap;
	public float direction;

	public virtual void Start () {

		speed = 15f;

		Wander();


	}
	
	public virtual void Update () {

		transform.position += transform.TransformDirection(Vector3.forward) * speed *Time.deltaTime;

			if((transform.position - wayPoint).magnitude < 1)
			{
				// when the distance between us and the target is less than 3
				// create a new way point target
				Wander();

			}
}
		
		public void Wander()
		{ 
			// does nothing except pick a new destination to go to
			
			//wayPoint =  new Vector3(Random.Range(transform.position.x - Range, transform.position.x + Range), 1, Random.Range(transform.position.z - Range, transform.position.z + Range));
			wayPoint= transform.localPosition + Random.insideUnitSphere * 30;
			wayPoint.y = 1;
			// don't need to change direction every frame seeing as you walk in a straight line only
			transform.LookAt(wayPoint);
			Debug.Log(wayPoint + " and " + (transform.position - wayPoint).magnitude);
		}
	
}
