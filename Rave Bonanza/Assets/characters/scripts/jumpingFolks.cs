using UnityEngine;
using System.Collections;

public class jumpingFolks : MonoBehaviour {

	public float jumpSpeed;
	public float jumpHeight;
	float gravity = 0.98f;
	bool falling = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	if(!falling){
		transform.position += Vector3.up * jumpSpeed * gravity * Time.deltaTime;
			if(transform.position.y >=jumpHeight){
				Fall();
			}
		}

		if(falling){
		transform.position += Vector3.down * jumpSpeed * gravity * Time.deltaTime;
		}


	}

	void OnCollisionEnter (Collision hitObj){

		if(hitObj.gameObject.tag == "Floor")
		{
			Invoke("Jump", 0.0f);
		}
	
	}

	void Jump(){
		falling = false;
	}

	void Fall(){
		falling = true;
	}

}
