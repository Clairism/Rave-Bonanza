using UnityEngine;
using System.Collections;

public class VomitManMoving : folksMoving {

	public bool vomiting;
	private float speedChange;
	

	public override void Start () {

		speed = 8f;
		vomiting = false;

		speedChange = 20f;

		Wander ();

	}

	public override void Update () {

		transform.position += transform.TransformDirection(Vector3.forward) * speed *Time.deltaTime;
		
		if((transform.position - wayPoint).magnitude < 1)
		{
			// when the distance between us and the target is less than 3
			// create a new way point target
			Wander();
			
		}

		if(vomiting == true){
			//slow down speed
			GameObject.FindGameObjectWithTag("Player").GetComponent<playerController>().playerSpeed -= speedChange;
			
			Invoke ("SpeedBack", 8f);
			
			//vomit particle effect
			vomiting = false;
		}
	
	}
	
	
	void SpeedBack(){

		GameObject.FindGameObjectWithTag("Player").GetComponent<playerController>().playerSpeed += speedChange;

	}
}
