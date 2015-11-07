using UnityEngine;
using System.Collections;

public class movingFolks : MonoBehaviour {

//	//float speed = 2f;
//	float xSpeed;
//	float ySpeed;
//
//	void Start () {
//		xSpeed = Random.Range(1f,5f)*Time.deltaTime;
//		ySpeed = Random.Range(1f,3f)*Time.deltaTime;
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//
////		xSpeed = Input.GetAxis("Horizontal") * speed;
//
//
//		//GetComponentInChildren<Rigidbody>().AddForce( new Vector3(xSpeed, ySpeed, 0));
//
//		GetComponent<Rigidbody>().transform.position = new Vector3(xSpeed, ySpeed, 0);
//	
//	}

	float speed;
	Vector3 folks;
	Vector3 folksNow;

	bool notOriginalPos = false;

	void Setup(){

		//folks = transform.position;
		speed = Random.Range (10f,20f);

	}

	void Update(){
		
//		transform.Translate (speed * Time.deltaTime,0, speed * Time.deltaTime, Space.World);
//		speed = Random.insideUnitCircle * 5;

		GetComponent<Rigidbody>().AddForce(new Vector3(speed,0,speed));

		//folksNow = transform.position;
		speedChanger();
	}

//	void speedChanger(){
//		speed = Random.Range (10f,20f);
//	}

	IEnumerator speedChanger() {
		yield return new WaitForSeconds(2f);
		speed = Random.Range (10f,20f);
	}
}
