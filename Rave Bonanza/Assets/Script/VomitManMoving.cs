using UnityEngine;
using System.Collections;

public class VomitManMoving : folksMoving {

	public bool vomiting;
	private float speedChange;
	

	public override void Start () {

		speed = 8f;
		vomiting = false;

		speedChange = 20f;

	}

	public override void Update () {

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
