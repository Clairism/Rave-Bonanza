﻿using UnityEngine;
using System.Collections;

public class jumpingFolks : MonoBehaviour {

	public float jumpSpeed;
	public float jumpHeight;
	//float gravity = 0.98f;
	bool falling = false;


	void Update () {

	if(!falling){
		//transform.position += Vector3.up * jumpSpeed * gravity * Time.deltaTime;
			GetComponent<Rigidbody>().velocity = new Vector3(0, Random.Range (jumpSpeed, 10f), 0);

			if(transform.position.y >=jumpHeight){
				Fall();
			}
		}

		if(falling){
		//transform.position += Vector3.down * jumpSpeed * gravity * Time.deltaTime;
			GetComponent<Rigidbody>().velocity = new Vector3(0, -Random.Range (jumpSpeed, 10f), 0);

		}


	}

	void OnCollisionEnter (Collision hitObj){

		if(hitObj.gameObject.tag == "Floor")
		{
			Invoke("Jump", Random.Range(0.5f, 1.5f));
		}
	
	}

	void Jump(){
		falling = false;
	}

	void Fall(){
		falling = true;
	}

}
